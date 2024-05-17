# Visual Basic .Net - ByteArray
* Đây là thư viện dùng để sử lí dữ liệu được tích hợp các tính năng nâng cao. giúp cho việc code được dễ dàng và thuận tiện.
* Phương thức cơ sở đầu vào và ra :
```
  - Memorystream : là nền để sử lí dữ liệu.
  - BinaryReader : đọc dữ liệu trong MemoryStream.
  - BinaryWriter : ghi dữ liệu vào MemoryStream.
```
  * Các phương thức đọc dữ liệu đầu vào :
```
  - ReadByte
  - ReadBytes
  - ReadSingle (float)
  - ReadShort
  - ReadReverseInt ( đảo ngược int)
  - .......
```
  * Các phương thức ghi dữ liệu đầu ra :
```
- WriteByte
- WriteBytes
- WriteReverseInt ( ghi đảo ngược int)
_ ....
```
* Các phương thức Nén dữ liệu : 
```
  - Deflate
  - Gzip
  - Zlib
  - Lzma
  - Brolti (rar5)
```
* Lấy mã hash :
  ```
  - md5
  - sha1
  - ....
  ```
* Nhận dạng xml, json...
# Cách dùng :
```vbnet
Dim Bytes as Byte() = IO.File.ReadAllBytes(OpenFileDialog1.FileName)
Dim source as ByteArray = New ByteArray(Bytes)
```
* Nén dữ liệu :
```sharp
source.Compress(CompressionAlgorithm.Zlib)
```
* Lấy mã hash :
```vbnet
Dim md5 as String = source.md5hash()
Dim sha1 as String = source.sha1hash()
```
* Serializator :
```vbnet
Dim bins as string = source.SerializerBinary(of String)
IO.File.WriteAlltext(SaveFileDialog1.FileName,bins)
```
* Thử tìm dữ liệu :
```vbnet
Dim xmldoc as XDocumnet 
Dim isXml as Boolean = source.TryGetXml(xmldoc)
If isXml = True Then
IO.File.WriteAllText(SaveFileDialog1.FileName,xmldoc)

```
* ....
