# MultiplayerFusion
 
This game can be played by a large number of participants (up to 20), the goal of the game is to drop as many points as possible to the other players and accumulate as many damage points as possible.
The 2 changes made to the game from the lesson are:
1. Adding a score to each player who, when he hits another player, a point is added to him.
   
    The script we added is: [score](https://github.com/game-devcourse/MultiplayerFusion/blob/main/Assets/Scripts/Score.cs).
   
    In addition to this script, we added in the script [RaycastAttack](https://github.com/game-devcourse/MultiplayerFusion/blob/main/Assets/Scripts/RaycastAttack.cs) in lines 70-72 that when the player hits another player, the score is also added to him in addition to decreasing the other player's health points.

2. Adding a shield at the beginning of the game that the first player who takes it is entitled to protection for a few seconds (which can be determined through Unity).
   
    The scripts we added are [Shield](https://github.com/game-devcourse/MultiplayerFusion/blob/main/Assets/Scripts/Shield.cs) and [ShieldSpawner](https://github.com/game-devcourse/ MultiplayerFusion/blob/main/Assets/Scripts/ShieldSpawner.cs).
   
    The shield script is attached to the player's prefab and responsible for activating the shield on the given player, and the ShieldSpawner is attached to the shield itself (in order for it to disappear and appear for all players alike and connect to the world itself), apart from this, we added to the script [RaycastAttack](https:// github.com/game-devcourse/MultiplayerFusion/blob/main/Assets/Scripts/RaycastAttack.cs) the test whether the player we are supposed to hit is protected and if yes then the hit doesn't work.

[For the game.](https://edenxhadar.itch.io/multiplayer-game)
