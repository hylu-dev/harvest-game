# Harvest

_A 2.5D narrative-driven adventure game_

>"Earth has become a feeding ground for grotesque monsters of unknown origin. Periodically during a time now known as "Harvest", these creatures appear out of nowhere attacking unsuspecting people. At the same time, humans equally began procuring supernatural abilities and now depend on them to survive the monsters reign of terror.
You follows the story of Liza, a girl studying at an academy of these supernatural individuals spending her days improving her abilities alongside other students. However, one day she learns of an unprecedented danger on the horizon and unfathomable power lurking behind the shadows. How she will use this knowledge is up to the player." — https://hylu-dev.itch.io/harvest

This project is an interactive story created for CCT382 at the University of Toronto Mississauga. The original narrative was created as a text adventure available to view here https://arcweave.com/app#/project/omE7BqDlRN. A 3D prototype was then devised.

This project can be downloaded from https://hylu-dev.itch.io/harvest. A demo can be viewed from there as well

---

## Sheridan PGDAP Reviewer Considerations

### Involvement

This is a team project consisting of me and three other members. My role in the project was story writing and programming. The narrative structure and days 1, 4, 5 of the story were primarily written by me with rest of the days and setting/backstory written between the other team members. Game assets were created/supplied by team members.

All Unity work including programming and rigging was done by Roy Lu (me) with most scripts relevant for review. The purpose of this project is to demonstrate my prior experience with Unity.

### Code Highlights

Folder structure follows the standard Unity 3D project structure. All scripts are found within harvest-game/Assets/Scripts. Below, I've highlighted a couple scripts along with some context.

- **Assets/PlayerController.cs**
  - Character movement through simple vector math
  - Camera positioning to character
- **Assets/StateController.cs & Assets/PlayerState.cs**
  - Classes to manage key player stats, items, and dialogue triggers
- **Assets/TraversalMenu.cs**
  - Generates a menu of locations for the player to traverse to
