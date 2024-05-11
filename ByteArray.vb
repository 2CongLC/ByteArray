Imports System
Imports System.Text
Imports System.Text.Json
Imports System.IO
Imports System.IO.Compression



Public Class ByteArray

  Public Enum Endian
    BIG_ENDIAN = 0
    LITTLE_ENDIAN = 1
  End Enum
  
 Private source as MemoryStream = Nothing
 Private reader as BinaryReader = Nothing
 Private writer as BinaryWriter = Nothing
 Private _endian as Endian = Nothing 
 
  
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




  
End Class  
