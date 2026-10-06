# SRT.Core.Files — Human Guide

File helpers for text, binary, Excel (EPPlus), and zip. This is **not** an `ISRTBasicConfigurations` plugin. Reference `SRT.Core.SRTFiles.csproj`. Namespace: `SRT.Core.SRTFile`.

`WEBPFile.cs` is fully commented out — there is no WebP API.

Path handling uses Windows-style `\` in several constructors. Empty directory paths may fall back to temp.

EPPlus: `Excel_WriteDataToFile` sets `ExcelPackage.LicenseContext = Commercial`.

See [API_REFERENCE](SRT.Core.Files.API_REFERENCE.md) and [COOKBOOK](SRT.Core.Files.COOKBOOK.md).
