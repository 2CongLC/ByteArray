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
 Private br as BinaryReader = Nothing
 Private bw as BinaryWriter = Nothing
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

Public sub deflate()
Using _inms As MemoryStream = New MemoryStream(source.ToArray())
                    Using _outms As MemoryStream = New MemoryStream()
                        Using dfs As IO.Compression.DeflateStream = New IO.Compression.DeflateStream(_outms, IO.Compression.CompressionMode.Compress, True)
                            _inms.CopyTo(dfs)
                        End Using
                        source = _outms
                    End Using
                End Using
End Sub

Public sub inflate()
        source.Position = 0
                Using _inms As MemoryStream = New MemoryStream(source.ToArray())
                    Using _outms As MemoryStream = New MemoryStream()
                        Using dfs As IO.Compression.DeflateStream = New IO.Compression.DeflateStream(_inms, IO.Compression.CompressionMode.Decompress, False)
                            dfs.CopyTo(_outms)
                        End Using
                        source = _outms
                    End Using
                End Using
 End sub

Private Function ReadLittleEndian(length As Integer) As Byte()
        Return br.ReadBytes(length)
    End Function

Private Function ReadBigEndian(length As Integer) As Byte()
        Dim little As Byte() = ReadLittleEndian(length)
        Dim reverse As Byte() = New Byte(length - 1) {}
        Dim i As Integer = length - 1, j As Integer = 0
        While i >= 0
            reverse(j) = little(i)
            i -= 1
            j += 1
        End While
        Return reverse
    End Function
            
    Public Function ReadBytesEndian(length As Integer) As Byte()
        If _endian = Endian.LITTLE_ENDIAN Then
            Return ReadLittleEndian(length)
        Else
            Return ReadBigEndian(length)
        End If
    End Function

Public Function ReadByte() As SByte
        Dim buffer As SByte = CSByte(source.ReadByte)
        Return buffer
    End Function

Public Sub ReadBytes(bytes As ByteArray, offset As UInteger, length As UInteger)
        Dim content As Byte() = New Byte(length - 1) {}
        source.Read(content, offset, length)
        bytes.WriteBytes(New ByteArray(content), 0, content.Length)
    End Sub
Public Function ReadBoolean() As Boolean
        Return source.ReadByte = 1
    End Function

 Public Function ReadDouble() As Double
        Dim bytes As Byte() = ReadBytesEndian(8)
        Return BitConverter.ToDouble(bytes, 0)
    End Function

Public Function ReadFloat() As Single
        Dim bytes As Byte() = ReadBytesEndian(4)
        Return BitConverter.ToSingle(bytes, 0)
    End Function

      Public Function ReadInt() As Integer
        Dim bytes As Byte() = ReadBytesEndian(4)
        Dim value As Integer = bytes(3) << 24 Or CInt(bytes(2)) << 16 Or CInt(bytes(1)) << 8 Or bytes(0)
        Return value
    End Function

    Public Function ReadMultiByte(length As UInteger, charset As String) As String
        Dim bytes As Byte() = ReadBytesEndian(CInt(length))
        Return Encoding.GetEncoding(charset).GetString(bytes)
    End Function       
            
  Public Function ReadShort() As Short
        Dim bytes As Byte() = ReadBytesEndian(2)
        Return bytes(1) << 8 Or bytes(0)
    End Function

    Public Function ReadUnsignedByte() As Byte
        Return CByte(source.ReadByte)
    End Function

Public Function ReadUnsignedInt() As UInteger
        Dim bytes As Byte() = ReadBytesEndian(4)
        Return BitConverter.ToUInt32(bytes, 0)
    End Function

   Public Function ReadUnsignedShort() As UShort
        Dim bytes As Byte() = ReadBytesEndian(2)
        Return BitConverter.ToUInt16(bytes, 0)
    End Function

 Public Function ReadUTFBytes(length As Integer) As String
        If length = 0 Then
            Return String.Empty
        End If
        Return New UTF8Encoding(False, True).GetString(br.ReadBytes(length))
        ' Return Encoding.GetEncoding("GB2312").GetString(br.ReadBytes(length))
        ' Return Encoding.GetEncoding("UTF-8", New EncoderReplacementFallback(String.Empty), New DecoderReplacementFallback(String.Empty)).GetString(br.ReadBytes(length))
    End Function 
            
Public Function ReadUTF() As String
        Dim length As Integer = ReadShort()
        Return ReadUTFBytes(length)
    End Function

            
            
End Class  
