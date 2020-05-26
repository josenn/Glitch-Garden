# Version 0.1

This version is very bare bones and just includes a splash screen and a
start menu (the splash screen loads into the start menu after a few seconds)

# Version 0.2

In this version I added the first level as well as the main game background
which I also made a little coordinate system out of!

# Version 0.3
## Animation
### Lizard Enemy
	Added a Lizard enemy with a walk and jump animation
	I would normally worry about functionality first but this is experimental
	And I haven't done anything with animation yet
### Trophy
	Added a trophy object with some animation (the top part rotates while the bottom is scaled up and down)
	Nice keyframe practice
### Movement
	Began adding and playing with enemy movement (so far using transform.Translate)
### Spawner
	Created an enemy spawner and started spawning enemies using a coroutine (currently has no end condition)
### Cactus
	Added the first defender, a Cactus, with an idle and attack animation
## Animation Events
### Lizard
	Added an animation event for setting the movement speed when a lizard jumps and when a lizard begins walking.
	1 when walking but 0 while still jumping (this prevents the lizard from sliding slightly while jumping) applicable to other attackers in the future potentially
### Cactus
	Created an animation event for instantiating projectiles and a new script for turning things into projectiles
# Scripts
### Health
	Created a health script for controlling health and dealing damage
	Implemented enemy health and damage so enemies can now be destroyed
# Particle Systems
	Began work on a deathFX Particle System
