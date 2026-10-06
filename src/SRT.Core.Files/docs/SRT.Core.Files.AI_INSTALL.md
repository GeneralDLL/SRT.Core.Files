# SRT.Core.Files — Where to copy files for each AI

Source: `SRT.Core.Files/src/SRT.Core.Files/docs/`  
Keep the `SRT.Core.Files.` prefix. These files do **not** auto-load from package `docs/`.

| Copy from `docs/` | Cursor | Claude | Codex | Humans |
|-------------------|--------|--------|-------|--------|
| `*.README.md`, `HUMAN_GUIDE`, `API_REFERENCE`, `COOKBOOK`, `AI_RULES` | `docs/` | `docs/` | `docs/` | `docs/` |
| `CURSOR_RULE.mdc` | `.cursor/rules/` | — | — | — |
| `CLAUDE.md` | — | root or `docs/` (+ pointer in existing `CLAUDE.md`) | — | — |
| `AGENTS.md` | — | — | root or `docs/` (+ pointer in existing `AGENTS.md`) | — |

Do not rename to unprefixed `README.md` / `AGENTS.md` / `CLAUDE.md` when other package docs coexist. Canonical: `docs/SRT.Core.Files.AI_RULES.md`.
