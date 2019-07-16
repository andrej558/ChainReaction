#Created by: Andrej Subasik. 
<h3>Short Description:</h3>
<p align = "justify">
In this game initially you have a circle that follows the cursor wherever it moves on the map. You have to click somewhere on the map and that circle gets positioned and you cannot re-position it. Once its at place, the balls moving around the map can stick to the circle turning themselves into circles. Each circle has a timer, meaning when it expires the circle disappears and it can no longer attract balls. Every circle that was previously a ball has number of points which is added to the players score once its caught. You beat the game by attracting as many balls as possible. For each round there is a minimum number of balls player needs to collect. At the end if you beat the game and if you are 1 of the top5 players, your nickname is written in HighScores.</p>
<h3>Detailed description:</h3> 
<p>
Once the application is built, <b>MainMenu.cs</b> is instantiated.</p>

 <p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001113-3b158f00-a35f-11e9-8c88-522bf2ad4847.png">
</p>

<p align = "justify">
From here player gets options to choose: Play the game, View High Scores, Learn more about the game or exit.
Once player hits <b>Play</b> he is prompted to enter his/her nickname. 
Player enters it so it can be added to best scores at end of the game.</p>
<p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001175-67311000-a35f-11e9-8803-09a3cce8bbf5.png">
</p>
<p align = "justify">
After player enters valid name he hits OK and the game starts. 
The balls are spawned at random on map and player has to try and catch as many as he can.
For each level there is a minimum number of balls player must collect in order to progress to next level
</p>
<p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001219-7c0da380-a35f-11e9-8c4b-b2c5b90358d2.png">
</p> 
<p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001236-829c1b00-a35f-11e9-9fbf-569ffee65003.png">
</p> 
<p align = "justify">
After player finishes each level he is asked if he wants to play again. If not the form closes and he is redirected to main menu</p>
Player can also check high scores:

 <p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001258-8c258300-a35f-11e9-8a00-2e57dbcecd8f.png">
</p>

<h3>Classes and methods:</h3>
<p align = "justify"> 
For this application a variety of classes and functions are used. 
The backbone of this project is the <b>Game.cs</b> class. When the application is being built an instance of this class is created. It is with help of this class that the terrain, balls, circles are being drawn, with the <b>Draw()</b> and <b>DrawTerrain()</b> functions.</p>
<p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001299-ac554200-a35f-11e9-9b8f-c9556e0591d4.png">
</p>
<p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001313-b0815f80-a35f-11e9-929a-1867d36d8477.png">
</p>
<p align = "justify">
 <b>Game.cs</b> also holds useful information, such as game width, height (int,int), game position (Point), reference to Player.cs (the current person playing this game), also a reference of the form the game is displayed at.</p>
<p>
Other significant classes are the <b>Ball.cs</b> and <b>Circle.cs</b>. They hold the information about the circles and balls, such as location, color, radius. With the help of these classes the balls and circles are drawn on the map. 
<b>Player.cs</b> holds the necessary information about the player, such as name(String), score(Int), when he started playing (DateTime), how long he played (Int).</p>
<p>
<b>FileReader.cs</b> and <b>FileWriter.cs</b> are used to manipulate the database.</p>
<p> 
<b>GameManager.cs</b> is used to try and add the player to high scores, only if he finishes the game and is one of top players. It adds player with the help of <b>SavePlayer()</b> function
</p>
<p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001439-ea526600-a35f-11e9-8b28-ce37c07bbdf9.png">
</p>
<p align = "justify">
Top players are displayed with help of <b>WriteHighScore()</b> and <b>CreateLabel()</b> methods in HighScores form.
</p>
<p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001454-f0e0dd80-a35f-11e9-8848-c5580bf760df.png">
</p>
<p align="center"> 
<img src="https://user-images.githubusercontent.com/47032530/61001475-f9391880-a35f-11e9-961c-0ebcdf36d0fa.png">
</p>

