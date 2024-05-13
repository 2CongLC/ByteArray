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
    _filesize = filesize.toString()
    

    
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

Public Property filesize as String
    Set (value as String)
      _filesize = value
     End Set
    Get
      Return _filesize
    End Get  
End Property

Public Function CompressCWS as Byte()

Try 
       
 Dim data as ByteArray = New ByteArray()
 data.WriteBytes(source,8)
 data.Compress()
 Dim buffer as ByteArray = New ByteArray()
 buffer.WriteMultiByte("CWS", "us-ascii")
 buffer.WriteByte(version)
 buffer.WriteByte(filesize)
 buffer.WriteBytes(data)
 Return buffer.ToArray()
Catch ex as Exception

End Try
        
End Function  

 Public Function DeCompressCWS as Byte()

Try 
      
 Dim data as ByteArray = New ByteArray()
 data.WriteBytes(source,8)
 data.UnCompress()
 Dim buffer as ByteArray = New ByteArray()
 buffer.WriteMultiByte("FWS", "us-ascii")
 buffer.WriteByte(version)
 buffer.WriteByte(filesize)
 buffer.WriteBytes(data)
 Return buffer.ToArray()
Catch ex as Exception

End Try
        
End Function     
  
Public Function CompressZWS as Byte()

Try 
       
 Dim data as ByteArray = New ByteArray()
 data.WriteBytes(source,8)
 data.Compress(CompressionAlgorithm.LZMA)
 Dim compressedLen As Long = data.BytesAvailable
      
Dim lzmaprops As ByteArray = New ByteArray()
lzmaprops.WriteBytes(data, 0, 3)
Dim lzmadata as ByteArray = New ByteArray()
 lzmadata.WriteBytes(data,12)
          
 Dim buffer as ByteArray = New ByteArray()
 buffer.WriteMultiByte("ZWS", "us-ascii")
 buffer.WriteByte(version)
 buffer.WriteByte(filesize)
 buffer.WriteByte(compressedLen)
 buffer.WriteBytes(lzmaprops)
 buffer.WriteBytes(lzmadata)   

 Return buffer.ToArray()
Catch ex as Exception

End Try
        
End Function
  
Public Function DeCompressZWS as Byte()

Try 
      
 Dim data as ByteArray = New ByteArray()
 data.WriteBytes(source,12)
 data.UnCompress(CompressionAlgorithm.LZMA)
 Dim buffer as ByteArray = New ByteArray()
 buffer.WriteMultiByte("FWS", "us-ascii")
 buffer.WriteByte(version)
 buffer.WriteByte(filesize)
 buffer.WriteBytes(data)
 Return buffer.ToArray()
Catch ex as Exception

End Try
        
End Function
  
Public Enum CompressTionTypes
    CWS
    ZWS
End Enum
    
Public Sub Compress(Byval outFile as String,Byval CompressTionType as CompressTionTypes)

 If CompressTionType = CompressTionTypes.CWS Then
      
    If (_signature = "FWS") AndAlso (_version >= 6) Then
      IO.File.WriteAllBytes(outFile, CompressCWS)
    End if
      
 Elseif CompressTionType = CompressTionTypes.ZWS Then
  
    If (_signature = "FWS") AndAlso (_version >=13) Then
      IO.File.WriteAllBytes(outFile,CompressZWS) 
    End if
      
  End if

End Sub  






  
End Class  
