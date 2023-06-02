# STFU
Super Type Fighter Ultra

Proof of concept/demo of app that translates written text input to movements in games, in this instance fighting games and 
more specifically movements and attacks/special attacks.
Use add-migration and update-database in the package manager console to create database locally, this is not used to get anything from right now though.

Works with Ultra Street Fighter 4 on Windows. Buttons in game need to be remapped like this;
UP -> LCTRL
DOWN -> LSHIFT
LIGHT PUNCH -> Q
MEDIUM PUNCH - W
HARD PUNCH ->  E
LIGHT KICK -> A
MEDIUM KICK -> S
HARD KICK -> D

Only the character Ryu is working and only special attacks at the moment. Movement and normals are precent but haven't been given a text input yet.

Run Ultra Street Fighter 4 in windowed mode, change controls under options in-game. Start STFU.
Working text commands to attacks so far: 

*hadoken
*shoryuken
*tatsumaki



TODO:
Add selectable difficulty
Migrate to newer framework
Add characters and list to select character from
Add games and list to select game from
Add mote special attack inputs
Move from SendKeys to XInput
