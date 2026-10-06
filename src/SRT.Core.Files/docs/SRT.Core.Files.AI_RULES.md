# SRT.Core.Files — AI Rules (canonical)

MUST:

- Use namespace `SRT.Core.SRTFile` and project `SRT.Core.SRTFiles`.
- Document and call only types in [API_REFERENCE](SRT.Core.Files.API_REFERENCE.md).
- Treat `Delete`/`WriteData` bool returns as success/failure (catch → false) unless Excel write (throws).

MUST NOT:

- Invent `WEBPFile` usage (commented out).
- Treat this package as a Core plugin (`Order` / `FeatureName` do not exist).
- Assume NonCommercial EPPlus license in code (write path sets Commercial).

Working rule: read docs first; if ambiguous, inspect code and update these docs. Keep `SRT.Core.Files.` prefixes.
