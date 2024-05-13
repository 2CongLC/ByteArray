Imports System
Imports System.IO
Imports System.Text


Public Class SWF


Private source as ByteArray
Private _signature as string
Private _version as integer
Private _fileSize as integer
Private _framesize as byte()
Private _framerate as byte()
Private _framecount as byte()
Private _tags as byte()
  

Public Sub New(Byval buffer as Byte())
    source = New ByteArray(buffer)
    
    Dim signature as ByteArray = New ByteArray()
    signature.WriteBytes(source,0,3) ' Offset = 0, Length = 3
    _signature = signature.toString()

    Dim version as ByteArray = New ByteArray()
    version.WriteBytes(source,3,1) ' Offset = 3, Length = 1
    _version = version.ToArray()(0)

    Dim filesize as ByteArray = New ByteArray()
    filesize.WriteBytes(source,4,4) 'Offset = 4, Length = 4
    _filesize = filesize.toString()
    
If _signature = "FWS" Then
      Dim framesize as ByteArray = New ByteArray()
      framesize.WriteBytes(source,8,9)
      _framesize = framesize.ToArray()

      Dim framerate as ByteArray = New ByteArray()
      framerate.WriteBytes(source,17,2)
      _framerate = framerate.ToArray()

      Dim framecount as ByteArray = New ByteArray()
      framecount.WriteBytes(source,19,2)
      _framecount = framecount.ToArray()

      Dim tags as ByteArray = New ByteArray()
      tags.WriteBytes(source,21)
      _tags = tags.ToArray()
      
End if
      
    
End Sub

Public Function Signature as String
      Return _signature 
End Function

Public Function Version as integer
      Return _version
End Function

Public Function Filesize as integer
      Return _filesize
End Function



Private Function GetNextByte(Byval buffer as byte()) as Byte
Dim index as integer = 0
 Dim result as byte = buffer(index)
    index +=1
    Return result
End Function    

    
Private Sub FrameSize()
Dim b as integer = GetNextByte(_framesize)
Dim nb as integer = b >> 3
b = b and 7
b <<= 5
Dim cb as integer = 2
Dim value as integer
For numfield as integer = 0 to 4 - 1
  value = 0
  Dim bitcount as integer = 0  
  While bitcount < nb
      If (b And 128) = 128 Then
        value = value + (1 << nb - bitcount - 1)
        End if
      b <<= 1
      b = b And 255

    
 Next   
    

End Sub

Public Function FrameRate  as Double
 Dim a as Byte = _framerate(0)
 Dim b as Byte = _framerate(1)
 Dim c as Double = (a + b) / 100
    Return c    
End Function
  
Public Function FrameCount as Integer
 Dim a as byte = _framecount(0)
 Dim b as byte = _framecount(1)
 Dim c as integer 
    c += (a << 8 * b)
 Return c
End Function

    
  
Private Function CompressCWS as Byte()

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

Private Function DeCompressCWS as Byte()

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
  
Private Function CompressZWS as Byte()

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
  
Private Function DeCompressZWS as Byte()

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
  
Enum CompressTionTypes
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

Public Sub DeCompress(Byval ouFile as String)

    If _signature = "CWS" Then
      IO.File.WriteAllBytes(ouFile, DeCompressCWS)
      Elseif _signature = "ZWS" Then
      IO.File.WriteAllBytes(outFile,DeCompressZWS)
      End if

 End Sub   




  
End Class  
