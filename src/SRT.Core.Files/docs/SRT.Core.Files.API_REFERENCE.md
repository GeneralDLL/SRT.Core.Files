# SRT.Core.Files — API Reference

Reviewed: Files repo `aacdbdf`, Core repo `95b0a5b`.  
Project: `SRT.Core.SRTFiles`. Namespace: `SRT.Core.SRTFile`.

---

## `BasicFile : IDisposable`

```csharp
public BasicFile(string fileExtension, string path, string nameFile)
public BasicFile(string fileExtension, string pathAndFile)
```

Properties: `FileExtension` (default `.txt`), `FilePath`, `FileName`, `FileFullPath`, `FileExists`, `FileDate` (`GetCreationTime`).  
`Delete()` / `WriteData` / `WriteDataLine` → bool (false on catch). `ReadData` / `ReadData<T>` (Newtonsoft). `ReadDataAsListOfLines(char separator = ';')` throws `Exception("Cannot read file => " + FileName, inner)`. `Dispose()` empty. `CopyFolder(source, dest)` static. Empty path on first ctor → `Path.GetTempPath()`. Missing directories created.

## `TXTFile : BasicFile`

`.txt` constructors: `(pathAndFile)` or `(path, nameFile)`.

## `BINFile : IDisposable`

Does **not** inherit `BasicFile`. Always `.bin`. `WriteData(string)` uses `BinaryWriter`. `ReadData()` → null if missing.

## `ExcelFile`

`.xlsx`. `Excel_GetDataFromFile(int worksheet)` 0-based.  
`Excel_WriteDataToFile(List<List<string>>, bool hasHeader = true, string worksheet = "srtSheet1")`  
Overload with `CellEffect` header/body. Overload `List<DataRow>`. Sets EPPlus `LicenseContext = Commercial`. Write wraps failures in `Exception("Write Data To File Excel", inner)`. Property `FileExist` (not `FileExists`).

## `ZipHelper`

`public static bool UnzipFile(string zipFilePath, string destinationPath, bool overwrite = false)`

## `WEBPFile`

No public API — entire source file is commented out.

## ExcelDetails (`SRT.Core.SRTFile.ExcelDetails`)

`BorderStyle`, `CellBorderStyle`, `CellFontStyle`, `CellEffect`, `DataCell`, `DataRow` as in source. `CellEffect.Set` and `DataRow.SetData` are **internal**.
