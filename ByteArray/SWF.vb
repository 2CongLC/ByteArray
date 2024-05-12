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
    header.WriteBytes(source,0,3) ' Position = 0, Byte = 0, 1, 2
    _signature = header.toString()

    Dim version as ByteArray = New ByteArray()
    version.WriteBytes(source,3,1) ' Position = 3, Byte = 3
    _version = version.toString()

    

    
End Sub

Public Property signature as String
    Set (value as String)
      _signature = value
     End Set
    Get
      Return _signature
    End Get  
End Property


  
End Class  
