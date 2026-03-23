# CrazyRun Game

This is an endless runner game developed in Unity, where the player has  to avoid obstacles and collect bonuses to survive as much as possible.

## Features
- **Procedural chunk generation** for an infinite level
- **Rigidbody-based physics** for player and obstacle interactions
- **Physics materials** applied to flying obstacles for more dynamic movement
- **Collision handling** for obstacles and pickups
- **Animator transitions** to make the player stumble after hitting an obstacle
- **Inheritance** used to organize shared pickup behavior
- **Dependency injection** for passing required references between spawned objects
- **WASD movement** for player control
- **Apple pickups** that increase game speed and trigger a particle effect
- **Coin pickups** that reward the player with a visible **+100 bonus**
- **Background music** for a more immersive experience
- **Cinemachine screen shake** effect when a boulder falls

## Gameplay

The player controls a character that can move using the **WASD** keys.  
As the game progresses, chunks of the level are spawned procedurally, each containing obstacles and collectible items.

The player must:

- avoid obstacles
- collect apples to increase speed
- collect coins to gain score bonuses

When the player collides with an obstacle, an animation is triggered to show the character stumbling. To make the environment feel more dynamic, falling boulders also trigger a **screen shake effect** using Cinemachine.

<img width="1243" height="607" alt="Screenshot 2026-03-23 124637" src="https://github.com/user-attachments/assets/4db2ce26-4215-4938-93e9-e161311f95e3" />

## Technical Overview

This project was built in **Unity** and includes several gameplay programming concepts:

### Procedural Generation
The map is generated using chunks that are spawned continuously as older chunks move out of view. This creates the illusion of an infinite path.

### Physics
The game uses **Rigidbody physics** for movement and interactions. Some obstacles use **physics materials** to achieve more interesting motion and behavior.

### Object-Oriented Programming
The project uses:
- **Inheritance** for shared pickup logic
- **Dependency Injection** to initialize spawned objects with required references such as managers or controllers

### Animation
The player uses **Animator transitions** to react to collisions, including a stumble animation when hitting an obstacle.

<img width="1359" height="662" alt="Screenshot 2026-03-23 124658" src="https://github.com/user-attachments/assets/2152e3d3-201c-43d4-85d0-9334baa7c387" />

### Audio and Effects
- Background music is played during gameplay
- Apples trigger a particle effect when collected
- Boulder impacts create a **Cinemachine impulse shake** for more feedback

<img width="1258" height="632" alt="Screenshot 2026-03-23 124644" src="https://github.com/user-attachments/assets/f608ef57-a5d9-4723-9da5-0eea45a44669" />

## Controls

- **W** - Move forward
- **A** - Move left
- **S** - Move backward
- **D** - Move right

## Pickups

### Apple
- Increases speed
- Triggers a particle visual effect

### Coin
- Adds **+100** points to the score
- Displays the bonus on screen

## Time System
- The game ends when the times reaches zero
- Checkpoints extend gameplay by adding +5 seconds

<img width="1181" height="656" alt="Screenshot 2026-03-23 124827" src="https://github.com/user-attachments/assets/745dc073-1bd1-4c5f-96cb-f876f850639b" />

## Tools and Technologies

- **Unity**
- **C#**
- **Cinemachine**
- **Unity Animator**
- **Unity Physics System**

## How to Run 
- Open project in Unity
- Load the Main Scene
- Press Play
- Survive as Long as Possible

OR
Access the game through the link: 


## Author
Created as part of a game development Unity Course by Arina Pereteatcu.
