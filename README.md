# SRT.Core.Files

File helpers (text, binary, Excel/EPPlus, zip) used by SRT apps.

**Target:** .NET 10  
**Project / assembly:** `SRT.Core.SRTFiles`  
**Namespace:** `SRT.Core.SRTFile`

Package docs: **[src/SRT.Core.Files/docs/SRT.Core.Files.README.md](src/SRT.Core.Files/docs/SRT.Core.Files.README.md)**

## Consume

```xml
<ProjectReference Include="..\SRT.Core.Files\src\SRT.Core.Files\SRT.Core.SRTFiles.csproj" />
```

This is **not** an SRT host plugin. `WEBPFile` is not compiled (source commented out).

## Quick start

```csharp
using SRT.Core.SRTFile;

var txt = new TXTFile(@"C:\temp", "notes");
txt.WriteData("hello");
```

See [COOKBOOK](src/SRT.Core.Files/docs/SRT.Core.Files.COOKBOOK.md).
