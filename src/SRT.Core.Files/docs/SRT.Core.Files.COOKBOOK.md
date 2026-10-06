# SRT.Core.Files — Cookbook

```xml
<ProjectReference Include="..\path\SRT.Core.Files\src\SRT.Core.Files\SRT.Core.SRTFiles.csproj" />
```

```csharp
using SRT.Core.SRTFile;
using SRT.Core.SRTFile.ExcelDetails;

var txt = new TXTFile(@"C:\temp", "notes");
txt.WriteData("hello");
var text = txt.ReadData();

var bin = new BINFile(@"C:\temp", "blob");
bin.WriteData("payload");

var xlsx = new ExcelFile(@"C:\temp", "report");
xlsx.Excel_WriteDataToFile(new List<List<string>>
{
    new() { "A", "B" },
    new() { "1", "2" },
});

ZipHelper.UnzipFile(@"C:\temp\a.zip", @"C:\temp\out", overwrite: true);
```

Excel styled rows use `DataRow` / `DataCell` / `CellEffect`. See [API_REFERENCE](SRT.Core.Files.API_REFERENCE.md).
