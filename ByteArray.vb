Imports System
Imports System.Text
Imports System.Text.Json
Imports System.IO
Imports System.IO.Compression



Public Enum Endians
    BIG_ENDIAN = 0
    LITTLE_ENDIAN = 1
End Enum
Public Enum CompressionAlgorithm
    Deflate
    Gzip
    Zlib
    LZMA
End Enum

Public Class ByteArray
 
 Private source as MemoryStream = Nothing
 Private reader as BinaryReader = Nothing
 Private writer as BinaryWriter = Nothing
 Private _endian as Endians = Nothing 
 
  
  Public Sub New(Byval buffer as Byte())

    source  = New MemoryStream()
    source.write(buffer,0,buffer.Length)
    source.Position = 0
    reader = New BinaryReader(source)
    writer = New BinaryWriter(source)
    _endian = Endian.LITTLE_ENDIAN
   
  End Sub

  Public ReadOnly Property Length As UInteger
        Get
            Return source.Length
        End Get
    End Property
  
 Public Property Position As UInteger
        Get
            Return source.Position
        End Get
        Set(value As UInteger)
            source.Position = value
        End Set
    End Property
  
    Public ReadOnly Property BytesAvailable As UInteger
        Get
            Return source.Length - source.Position
        End Get
    End Property

Public Property Endian As Endians
        Set(value As Endian)
            _endian = value
        End Set
        Get
            Return _endian
        End Get
    End Property

Public sub Clear()
Dim buffer as byte() = source.GetBuffer()
        Array.Clear(buffer, 0, buffer.Length)                                  
      source.Position = 0   
         source.SetLength(0)                                          
 End sub

Public Sub Compress(ByVal Optional algorithm As CompressionAlgorithm = CompressionAlgorithm.Zlib)
        Select Case algorithm
            Case CompressionAlgorithm.Deflate
      Using _inms As MemoryStream = New MemoryStream(source.ToArray())
                    Using _outms As MemoryStream = New MemoryStream()
                        Using dfs As IO.Compression.DeflateStream = New IO.Compression.DeflateStream(_outms, IO.Compression.CompressionMode.Compress, True)
                            _inms.CopyTo(dfs)
                        End Using
                        source = _outms
                    End Using
                End Using
                Exit Select
        Case CompressionAlgorithm.Zlib
                Using _inms As MemoryStream = New MemoryStream(source.ToArray())
                    Using _outms As MemoryStream = New MemoryStream()
                        Using zls As IO.Compression.ZlibStream = New IO.Compression.ZlibStream(_outStream, IO.Compression.CompressionMode.Compress, True)
                            _inms.CopyTo(zls)
                        End Using
                        source = _outms
                    End Using
                End Using
                Exit Select
          Case CompressionAlgorithm.LZMA
                Using _inms As MemoryStream = New MemoryStream(source.ToArray())
                    Using _outms As MemoryStream = New MemoryStream()
                        Dim propIDs As SevenZip.CoderPropID() = {SevenZip.CoderPropID.DictionarySize, SevenZip.CoderPropID.PosStateBits, SevenZip.CoderPropID.LitContextBits, SevenZip.CoderPropID.LitPosBits, SevenZip.CoderPropID.Algorithm, SevenZip.CoderPropID.NumFastBytes, SevenZip.CoderPropID.MatchFinder, SevenZip.CoderPropID.EndMarker}
                        Dim properties = {1 << 23, 2, 3, 0, 1, 128, "bt4", False}
                        Dim encoder As SevenZip.Compression.LZMA.Encoder = New SevenZip.Compression.LZMA.Encoder()
                        encoder.SetCoderProperties(propIDs, properties)
                        encoder.WriteCoderProperties(_outms)
                        Dim fileSize As Long = _inms.Length
                        For i As Integer = 0 To 8 - 1
                            _outms.WriteByte(fileSize >> 8 * i)
                        Next
                        _outms.Flush()
                        encoder.Code(_inms, _outms, -1, -1, Nothing)
                        _outms.Flush()
                        source = _outms
                    End Using
                End Using
                Exit Select
        End Select
        End Sub


  
End Class  
