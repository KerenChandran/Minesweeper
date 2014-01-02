Minesweeper
===========

You can run the program by locating and executing the Minesweeper.exe file (Minesweeper->bin->Debug->Minesweeper.exe). 
You can also execute the program by opening the Minesweeper.sln file.

Minesweeper Manual:
The Object:
•	Find the empty squares as fast as possible while avoiding all the mines.

How To Play:
•	Select your difficulty from the play menu 
•	Push the smiley button on top of the board in order to play.
•	Left click on a square in order to select it.
•	Right click on a square in order to flag it if you believe it is a mine. If you right click a flagged square, then it will put a question mark on it. Place a question mark on a square if you are unsure about what may be under the square.
•	The numbers on an uncovered square means how many mines are hidden in the squares surrounding it. 
•	Clear the board without uncovering a mine to win.
•	If you uncover a mine you lose.

Difficulty Setting:
o	Beginner: 10x10 board, 10 mines.
o	Intermediate: 20x20 board, 20 mines.
o	Expert: 30x30 board, 30 mines.

How it works:
•	It recursively uncovers any empty boxes until it reaches a square with a value and not a mine.
•	The game stops when a mine is uncovered.
•	The game will only detect clicks that are inside the form.

Menu:
•	File contains the options to play a new game and exit option.
•	Difficulty Setting contains three difficulty options (beginner, intermediate, expert).
•	Extras contains help and about  and are accessible with shortcuts (F1 and F11).
