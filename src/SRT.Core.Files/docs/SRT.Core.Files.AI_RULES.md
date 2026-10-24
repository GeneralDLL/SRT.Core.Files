# SRT.Core.Files — AI Rules (canonical)

MUST:

- Use namespace `SRT.Core.SRTFile` and project `SRT.Core.SRTFiles`.
- Document and call only types in [API_REFERENCE](SRT.Core.Files.API_REFERENCE.md).
- Treat `Delete`/`WriteData` bool returns as success/failure (catch → false) unless Excel write (throws).

MUST NOT:

- Invent `WEBPFile` usage (commented out).
- Treat this package as a Core plugin (`Order` / `FeatureName` do not exist).
- Set `ExcelPackage.LicenseContext`. EPPlus 8 uses `ExcelPackage.License`: commercial key from `EPPlusLicense=Commercial:<key>`, otherwise `SetNonCommercialOrganization("SRT")` when unset.

Working rule: read docs first; if ambiguous, inspect code and update these docs. Keep `SRT.Core.Files.` prefixes.
