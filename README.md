# Ship and Fish
## Overview
This Unity project showcases a simple game mechanic where a player controls a ship to collect fish in a game world. Using mouse clicks, the player can spawn fish at the cursor's location, and the ship will automatically move towards and collect these fish.

## Features
Fish Spawning: Players can spawn fish into the game world by right-clicking with the mouse. The fish will appear at the location of the cursor.
Fish Collection: A ship moves towards the nearest fish and collects it upon contact. The ship aims for one fish at a time, waiting until it has almost stopped before seeking the next target.
Dynamic Fish Tracking: The game keeps track of all spawned fish and their collection status through a centralized FishCollector system.
## Getting Started
### Prerequisites
Unity Hub
Unity Editor
Visual Studio or another compatible IDE for editing C# scripts
###Installation
Clone the repository or download the project: If you have git installed, you can clone the repository using the following command: git clone [repository-url]
Alternatively, download the project as a ZIP file and extract it.

Open the project in Unity Hub: Launch Unity Hub, go to the "Projects" tab, and click on "ADD". Navigate to the project folder and select it. Unity will then import the project and its assets.

Open the project in the Unity Editor: Once the project appears in your Unity Hub projects list, click on it to open the project in the Unity Editor.
### Running the Game
Press the Play button in the Unity Editor to start the game in the editor.
Right-click in the game view to spawn fish at the cursor's location.
Click on the ship to initiate its movement and watch as it collects the fish.
Scripts Overview
Ship.cs: Controls the ship's movement and fish collection logic.
FishCollector.cs: Manages fish spawning and tracking within the game.
### Project Structure
Assets: Contains all the project assets, including sprites, scripts, and scenes.
Sprites: Folder for graphical assets.
Scripts: Contains C# scripts for game functionality.
Scenes: Where the game scenes are stored, including the main game scene ("SampleScene").
ProjectSettings: Unity-generated project settings files.
## Contributing
I'm always looking to improve and expand this project, and your input is invaluable! If you've discovered a bug, have a feature suggestion, or any kind of improvement in mind, please feel free to share your thoughts. You can open an issue or, if you're inclined, submit a pull request with your proposed changes. Collaboration and feedback are greatly appreciated, as they help make this project even better. Thank you for your support and interest!

### Demo Video
Check out the gameplay demo to see Ship and Fish in action. https://www.youtube.com/watch?v=4SsZDhB2y5U

## Acknowledgments
Unity Technologies for providing the Unity Engine and its documentation.
