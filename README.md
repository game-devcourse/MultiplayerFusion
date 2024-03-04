# MultiplayerFusion
 
במשחק זה ניתן לשחק מספר רב(עד 20) משתתפים, המטרה במשחק היא להוריד כמה שיותר נקודות לשחקנים האחרים ולצבור כמה שיותר נקודות פגיעה.
2 השינויים שנעשו במשחק מהשיעור הם:
1. הוספת ניקוד לכל שחקן שכאשר הוא פוגע בשחקן אחר מתווספת לו נקודה.
   
   הסקריפט שהוספנו הוא: [score](https://github.com/game-devcourse/MultiplayerFusion/blob/main/Assets/Scripts/Score.cs).
   
   בנוסף לסקריפט זה הוספנו בסקריפט [RaycastAttack](https://github.com/game-devcourse/MultiplayerFusion/blob/main/Assets/Scripts/RaycastAttack.cs) בשורות 70-72 שכאשר השחקן פוגע בשחקן אחר גם מתווסף לו הניקוד בנוסף להורדת הניקוד של השחקן האחר.

2. הוספת מגן בתחילת המשחק שהשחקן הראשון שלוקח אותו זכאי להגנה של כמה שניות(אותן ניתן לקבוע דרך הunity).
   
   הסקריפטים שהוספנו הם [Shield](https://github.com/game-devcourse/MultiplayerFusion/blob/main/Assets/Scripts/Shield.cs) ו[ShieldSpawner](https://github.com/game-devcourse/MultiplayerFusion/blob/main/Assets/Scripts/ShieldSpawner.cs).
   
   הסקריפט של הShield מחובר לprefab של השחקן ובעצם הוא האחראי להפעיל את המגן על השחקן הנתון, והShieldSpawner מחובר לshield עצמו(על מנת שייעלם ויופיע אצל כל השחקן כאחד ובעצם יהיה מחובר לעולם עצמו), מלבד זאת כמובן שהוספנו לסקריפט [RaycastAttack](https://github.com/game-devcourse/MultiplayerFusion/blob/main/Assets/Scripts/RaycastAttack.cs) את הבדיקה האם השחקן שבו אנו אמורים לפגוע מוגן ובמידה וכן אז הפגיעה לא עובדת.

[למשחק](https://edenxhadar.itch.io/multiplayer-game)
