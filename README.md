# Combat Cinderella — Stardew Valley

A fan-made **Stardew Valley 1.6** content mod bringing characters and locations from the *Combat Cinderella* story universe into Pelican Town.

**Status:** `v0.8.6-beta` — playable development build, tested by the project author; not a polished final release.

> **Unofficial fan project.** Not affiliated with or endorsed by ConcernedApe, Stardew Valley, or the developers of SMAPI and Content Patcher.

## Features

- **Carrie Ko (Combat Cinderella)** and **Natalica Ko (Shadow Cub)** as custom, non-romanceable NPCs, with walking sprites, portraits, dialogue, and schedules.
- **Ko Estate**, an outdoor family estate map, and **Ko Residence**, an interior home map.
- A **Backwoods driveway** leading north to the estate, including a return route.
- Custom map artwork and incremental terrain integration around the driveway.

### Current map navigation

| Connection | Details |
| --- | --- |
| Backwoods → Ko Estate | Walk north along the driveway centered at tile X=35; the warp is at (35,1) / (36,1). |
| Ko Estate → Backwoods | Estate south exit; returns near Backwoods (35,10). |
| Ko Estate ↔ Ko Residence | Doorway and return warps are defined in the content pack. |

The Backwoods entrance and northbound teleport have been tested in-game. Other features are still in development and may need further testing.

## Requirements

- **Stardew Valley 1.6** (developed/tested against 1.6.15)
- **SMAPI 4.x** (tested with 4.5.2)
- **Content Patcher 2.x** (tested with 2.9.1)

Install the dependencies first, then launch Stardew Valley through SMAPI.

## Installation

1. Download a release package containing the **complete** `CombatCinderella` Content Patcher pack (not just an incremental driveway patch).
2. Extract it into your Stardew Valley `Mods/` folder. The folder containing `manifest.json` must also contain `content.json` and `assets/`.
3. Launch through SMAPI and load a save.
4. Visit **Backwoods** and follow the new road north.

Example Linux layout (Steam default; yours may differ):

```text
~/.local/share/Steam/steamapps/common/Stardew Valley/Mods/
└── CombatCinderella/
    ├── manifest.json
    ├── content.json
    └── assets/
        ├── Characters/
        ├── Portraits/
        ├── Dialogue/
        ├── Schedules/
        └── Maps/
```

**Important:** The v0.8.6 driveway ZIP distributed during development is an **incremental update**, not a complete install. Do not distribute it alone as the full mod.

## Content pack identity

The Content Patcher pack must keep its established unique ID:

```json
"UniqueID": "JohnTsai.CombatCinderella"
```

Do not change this ID between updates: custom NPC and location names use it as a prefix. Set the Content Patcher pack's `manifest.json` version to `0.8.6` for this release.

## Development layout

```text
CombatCinderella/
├── manifest.json
├── content.json
└── assets/
    ├── Characters/        # NPC walking sprites
    ├── Portraits/          # NPC dialogue portraits
    ├── Dialogue/           # Character dialogue JSON
    ├── Schedules/          # NPC schedules
    └── Maps/               # TMX maps and tilesheets
```

A separate `KoEntranceDiagnostics` SMAPI C# utility was used for testing map coordinates and warps. It is a **developer tool**, not a dependency of the Content Patcher pack. If included in this repository, keep its source in a separate directory and document its build instructions independently.

## Known limitations

- The Backwoods road's cliff-side terrain is an artistic approximation, not a complete reconstruction of the vanilla cliff tiles and collision.
- NPC dialogue, schedules, and map interactions remain subject to gameplay testing.
- The mod is not a finished expansion; expect visual adjustments and compatibility fixes.

## Reporting issues

When filing an issue, include your Stardew Valley, SMAPI, and Content Patcher versions, a description of what happened, steps to reproduce, and a SMAPI log (remove private information before posting). Screenshots of the Backwoods entrance are especially helpful for terrain problems.

## Credits and rights

- **Combat Cinderella** universe and this fan-mod implementation: John Tsai / project contributors, as applicable.
- **Stardew Valley**: ConcernedApe.
- **SMAPI** and **Content Patcher**: their respective maintainers.

See [LICENSE](LICENSE) for the license covering original source/configuration contributions. **Game assets, third-party artwork, trademarks, and other third-party material are not automatically covered by that license.** Only publish assets you own or have permission to redistribute. Document asset provenance and permissions before publishing a release.

## Changelog

See [CHANGELOG.md](CHANGELOG.md).
