Section 1: Project Description
This project is a 2D spaceship shooter game where the player controls a spaceship to avoid obstacles (rocks) and shoot bullets. 
The game includes background stars that move continuously to create a dynamic space environment, giving the effect of forward movement through space.

Section 2: Overview
The game features:

Player Movement: Controlled by keyboard arrow keys to navigate the spaceship up and down.
Obstacles (Rocks): Rocks appear from the right side of the screen and move to the left, resetting to random positions once they pass off-screen.
Bullets: The player’s spaceship shoots bullets that move horizontally across the screen, resetting their position when they reach a certain distance.
Animated Stars: Stars move across the background, creating an illusion of motion through space.


Section 3: System Architecture
The system architecture comprises:

Player (Spaceship): A PictureBox control for the spaceship image, which is moved up or down based on user input.

Bullets: Another PictureBox that moves horizontally and resets when it reaches the right boundary.

Obstacles (Rocks): Multiple PictureBox controls that represent rocks, randomly resetting their position after they exit the screen.

Background Stars: PictureBox controls tagged as "star" that create a scrolling star background by moving to the left continuously.

Timers: A Timer component (timer1) that triggers updates for the bullet, stars, and rocks, ensuring continuous game animation.


Section 4: Data Dictionary
Data Element	Type	Description

Player	PictureBox	Represents the player’s spaceship that moves up and down within a set boundary.

bullet	PictureBox	Represents the bullet image, moving horizontally and resetting position when reaching the right edge.

rock1, rock2	PictureBox	Represents rocks (obstacles) that move from right to left and reset at random vertical positions.

timer1	Timer	Controls the movement intervals for bullets, stars, and rocks.

rnd	Random	Generates random values for resetting the rock positions.


Section 5: Data Design

Player Position: Controlled by keyboard inputs; the Top property is modified within a bounded range to move the player up or down.

Bullet Movement: bullet.Left increases at each Timer tick to move it rightward; resets to player’s position when off-screen.

Rocks (Obstacles): rock1 and rock2 move left and reset at random vertical positions when they go off-screen to create a new challenge.

Stars: All controls tagged as "star" are iterated over and moved left, resetting their Left property when they go off-screen to simulate an endless scrolling background.


Section 6: User Interface Design
The user interface includes:

Game Area: A panel where the spaceship, rocks, stars, and bullets are displayed.

Player Controls: Arrow keys to move the spaceship up and down.

Animated Elements: Bullets, rocks, and stars create an engaging and interactive environment by moving continuously across the screen.
