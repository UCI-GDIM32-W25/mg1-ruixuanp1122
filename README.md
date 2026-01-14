[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
# MG1：Unity & C# review
## Devlog
Ruixuan Pan, she/her


In the MG1 breakdown activity, our group described the game world in terms of objects and their relationships, including Seeds, the Player, and UI/Text. According to that, I created a Player GameObject to represent the player object described in the breakdown. The player has attributes such as position and speed, and actions including movement using WASD keys and planting seeds with the Space key. To represent seeds, I created a PlantGameObject as a Prefab rather than placing seeds directly in the Scene. This allowed seeds to exist only when they are planted by the player. In my breakdown, I identified the player’s actions as movement and planting seeds. And I implemented in the Player script that player movement is handled in the Update() method using Input.GetAxisRaw, allowing the player to move with the WASD or arrow keys. The breakdown also describes the interaction “seed → UI (appear, inform, increase + decrease)”, which is implemented through the script. This script manages how the UI responds when a seed is planted. Each time a seed appears in the world, the UI updates to decrease the number of seeds remaining and increase the number of seeds planted.PlantCountUI. I used a separate GameObject and script to manage UI updates and updates only the numeric TextMeshPro elements, allowing the labels to remain static while the values change. After replay Professor's game, I adjusted my UI approach. I initially placed a seed object directly in the Scene, which caused an extra seed to appear at the start of the game. After revisiting the breakdown and the project requirements, I removed all seeds from the Scene and relied entirely on the Prefab system so that seeds only appear when planted by the player.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
