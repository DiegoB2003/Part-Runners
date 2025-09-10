# Part Runners

Team Members: **Diego Bravo**, Musa Elqaq, Nathaniel Herrera
Download [here](https://github.com/DiegoB2003/Part-Runners/releases/tag/v0.1.1)

## How To Play + Controls
Start the game by clicking "Host". Have another player enter the join code displayed at the upper left of your screen and click "Join".
You may start the game by racing each other to obtain and submit all parts around the levels. You may only carry up to 3 parts at a time.
Touch the turn-in station multiple times if you are carrying multiple parts; only 1 part is submitted each time the turn-in station is touched.
You may also convert carried parts into bullets that will make the other player drop carried parts if you hit them.
- Use **WASD** for forward, right, back, and left movement.
- Press **Space** to jump.
- Use the **Mouse** to look around.
- Press **C** to convert carried parts into bullets.
- **Left Mouse Click** shoot bullets.
- Move to and touch part blocks to obtain parts.
- Move to and touch the turn-in station to submit parts.
- Move to and touch the trampoline pads near the spawn to get launched up.
- Move to and walk on the conveyor paths on the sides of the map for a slight speed boost.

## My contributions:
- Implemented network functionality (Host+Join) using Netcode.
- Regression tested and fixed network implementation throughout development.
- Synced and configured network+game objects.
- Added and implemented a turn-in station in the level.
- Implemented bullet logic.
- Configured UI for each player to ensure network logic does not interfere with client-side UI.
- Squashed many bugs before our deadline to provide a solid demonstration.
- Modified prototype to add physical components such as a trampoline and conveyor.
- Added billboards above each part block to show the player what each block provides.

This prototype was developed for an Undergraduate project at the University of Illinois at Chicago in a CS 426 course.
