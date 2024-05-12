Imports System
Imports System.IO
Imports System.Text


Public Class SWF


Private source as ByteArray
Private _signature as string
Private _version as integer
Private _fileSize as integer
  

Public Sub New(Byval buffer as Byte())
    source = New ByteArray(buffer)
    
    Dim header as ByteArray = New ByteArray()
    header.WriteBytes(source,0,3) ' Offset = 0, Length = 3
    _signature = header.toString()

    Dim version as ByteArray = New ByteArray()
    version.WriteBytes(source,3,1) ' Offset = 3, Length = 1
    _version = version.toString()

    Dim filesize as ByteArray = New ByteArray()
    filesize.WriteBytes(source,4,4) 'Offset = 4, Length = 4

    
End Sub

Public Property signature as String
    Set (value as String)
      _signature = value
     End Set
    Get
      Return _signature
    End Get  
End Property

Public Property version as String
    Set (value as String)
      _version = value
     End Set
    Get
      Return _version
    End Get  
End Property
  
End Class  