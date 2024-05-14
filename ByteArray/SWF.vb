Imports System
Imports System.IO
Imports System.Text


Public Class SWF



    Private source As ByteArray

    Private _signature As String

    Private _version As Integer

    Private _fileSize As Integer

    Private _framesize As Byte()

    Private _framerate As Byte()

    Private _framecount As Byte()

    Private _tags As Byte()

    Private mWidth As Integer = 0

    Private mHeigth As Integer = 0


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

            Dim framesize As ByteArray = New ByteArray()
            framesize.WriteBytes(source, 8, 9)
            _framesize = framesize.ToArray()

            Dim framerate As ByteArray = New ByteArray()
            framerate.WriteBytes(source, 17, 2)
            _framerate = framerate.ToArray()

            Dim framecount As ByteArray = New ByteArray()
            framecount.WriteBytes(source, 19, 2)
            _framecount = framecount.ToArray()

            Dim tags As ByteArray = New ByteArray()
            tags.WriteBytes(source, 21)
            _tags = tags.ToArray()


        End If

        FrameSize()
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

Public ReadOnly Property Width as integer
    Get
      Return mWidth
    End Get
End Property

Public ReadOnly Property Heigth as integer
    Get
      Return mHeigth
    End Get
End Property


Private Function GetNextByte(Byval buffer as byte()) as Byte
Dim index as integer = 0
 Dim result as byte = buffer(index)
    index +=1
    Return result
End Function


    Public Sub FrameSize()
        Dim b As Integer = GetNextByte(_framesize)
        Dim nb As Integer = b >> 3
        b = b And 7
        b <<= 5
        Dim cb As Integer = 2
        Dim value As Integer
        For numfield As Integer = 0 To 4 - 1
            value = 0
            Dim bitcount As Integer = 0
            While bitcount < nb
                If (b And 128) = 128 Then
                    value = value + (1 << nb - bitcount - 1)
                End If
                b <<= 1
                b = b And 255
                cb -= 1
                bitcount += 1

                If cb < 0 Then
                    b = GetNextByte(_framesize)
                    cb = 7
                End If
            End While
            value /= 20
            Select Case numfield
                Case 0
                    mWidth = value
                Case 1
                    mWidth = value - mWidth
                Case 2
                    mHeigth = value

                Case 3
                    mHeigth = value - mHeigth
            End Select



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



    Private Function CompressCWS() As Byte()
        Dim data As ByteArray = New ByteArray()
        data.WriteBytes(source, 8)
        data.Compress()
        Dim buffer As ByteArray = New ByteArray()
        buffer.WriteMultiByte("CWS", "us-ascii")
        buffer.WriteByte(Version)
        buffer.WriteByte(Filesize)
        buffer.WriteBytes(data)
        Return buffer.ToArray()
    End Function

    Public Function DeCompressCWS() As Byte()

        Dim data As ByteArray = New ByteArray()
        data.WriteBytes(source, 8)
        data.Uncompress()
        Dim buffer As ByteArray = New ByteArray()
        buffer.WriteMultiByte("FWS", "us-ascii")
        buffer.WriteByte(Version)
        buffer.WriteByte(Filesize)
        buffer.WriteBytes(data)
        Return buffer.ToArray()

    End Function

    Public Function CompressZWS() As Byte()

        Dim data As ByteArray = New ByteArray()
            data.WriteBytes(source, 8)
            data.Compress(CompressionAlgorithm.LZMA)
            Dim compressedLen As Long = data.BytesAvailable

            Dim lzmaprops As ByteArray = New ByteArray()
            lzmaprops.WriteBytes(data, 0, 3)
            Dim lzmadata As ByteArray = New ByteArray()
            lzmadata.WriteBytes(data, 12)

            Dim buffer As ByteArray = New ByteArray()
            buffer.WriteMultiByte("ZWS", "us-ascii")
            buffer.WriteByte(Version)
            buffer.WriteByte(Filesize)
            buffer.WriteByte(compressedLen)
            buffer.WriteBytes(lzmaprops)
            buffer.WriteBytes(lzmadata)

            Return buffer.ToArray()

    End Function

    Public Function DeCompressZWS() As Byte()


        Dim data As ByteArray = New ByteArray()

        data.WriteBytes(source, 12)

        data.Uncompress(CompressionAlgorithm.LZMA)

        Dim buffer As ByteArray = New ByteArray()

        buffer.WriteMultiByte("FWS", "us-ascii")

        buffer.WriteByte(Version)

        buffer.WriteByte(Filesize)

        buffer.WriteBytes(data)

        Return buffer.ToArray()

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

    Public Sub DeCompress(ByVal outFile As String)

        If _signature = "CWS" Then
            IO.File.WriteAllBytes(outFile, DeCompressCWS)
        ElseIf _signature = "ZWS" Then
            IO.File.WriteAllBytes(outFile, DeCompressZWS)
        End If

    End Sub





End Class  
