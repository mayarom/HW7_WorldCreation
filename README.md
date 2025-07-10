# Weekly Assignment – Building a World and Pathfinding in 3D  
**Homework 7 – Game Development Course – Ariel University**

This Unity project was created as part of **Homework 7** in the Game Development course.  
The goal was to combine two components: world building and player control, in a custom 3D scene.

---

## ✅ My Chosen Ideas & Implementation

### 1. 🌍 Scene Modeling (`Homework-1-scene-modeling`)
I built a full **3D environment** from scratch using Unity primitives (Cubes, Planes, and custom layout):

- A **main hall** with walls, red floor, and defined boundaries (`Floor_MainRoom`, `Walls`)
- A **staircase** leading to a small elevated room
- A **secondary room** that feels like a secret escape passage
- An **outdoor area** with a garden and a raised finish platform
- Custom **materials and colors** (e.g., red stairs and floor)
- Indoor lighting (`Room_Light`) for realism
- Logical layout with progression from inside to outside
- Objects renamed to meaningful names (`MainStructureWall`, `FakeDoor`, `FinishZone`, etc.)

The world includes two main spaces (interior and exterior), allowing the player to explore and ultimately escape.

---

### 2. 🎮 Player Control (`Homework-2-Player`)
I implemented player mechanics using C# scripts and Unity physics:

- **WASD movement** for walking
- **Jumping** using the Space key
- **Smooth camera follow** using `CameraFollow.cs`, with `offset` and `LookAt`
- UI message on game start that fades in/out (Canvas + script)
- Collision detection via `FinishTrigger.cs` to detect when the player reaches the victory platform

Once the player steps on the finish zone, a new scene (`VictoryScene`) is loaded with a "You Win" message.

---

## 🏁 Game Objective
The player starts inside a 3D room and must:

1. Move, explore, and jump to reach the stairs
2. Find the small side room and exit to the garden
3. Reach the raised **FINISH** platform
4. Trigger a transition to the `VictoryScene`

---

## 🎥 Scenes
- `MainScene`: Full 3D playable level with player and camera
- `VictoryScene`: Simple win screen with a "Victory!" message

---

## 🧪 How to Play
1. Open the project in Unity (v6000.0.24f1 or later)
2. Load the `MainScene`
3. Press **Play**
4. Move using **WASD**, jump with **Space**
5. Reach the finish platform to win

---

## 📁 Project Structure (Highlights)
- `Assets/Scripts/` – `PlayerMovement.cs`, `CameraFollow.cs`, `FinishTrigger.cs`, `IntroTextFade.cs`
- `Scenes/MainScene.unity` – The full game level
- `Scenes/VictoryScene.unity` – The victory scene
- `Materials/` – Colored materials (e.g., red stairs, white walls)
- `Canvas/IntroText` – UI instructions for the player

---

## 👤 Author
**Maya Rom**  
Student ID: 207485251  
Ariel University – Game Development Course  
Editor version: `Unity 6000.0.24f1 (LTS)`

---

