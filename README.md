This app is a small game that consists of a 5x5 board where you can place walls and a robot, the robot can move through the board
but can't move through the walls.

to get info about the robot position you should use the command report, that will tell you the position of the robot an its direction.

The different commands for this program are:
place_robot x(integer coodinate),y(integer coordinate),direction(NORTH,EAST,WEST OR SOUTH)
place_wall x(integer coodinate),y(integer coordinate)
report
move
left
right
restart
quit

example:

place_robot 1,1,NORTH
report
move
report
place_wall 1,3
move
report
right
move
report
