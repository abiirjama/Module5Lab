using Module5Lab;
// create a new player with one life and add points to the 
//palyer's score
Player player = new Player("frankenstein", 1);

player.addpoints(100);
//display the player's score
Console.WriteLine("Welcome to the game! your  score is: " + player.getscore() + "You have " + player.GetLivesLeft() + "lives left!");
//kill off the player's character 
player.kill();
//let the player know their character was killed 
Console.WriteLine("An orc attacks you> Sorry, you wewre killed yopu have" + player.GetLivesLeft() + "lives left");
//create a super player 
SuperPlayer superPlayer = new SuperPlayer();
superPlayer.addpoints(200);
superPlayer.Fly();
Console.WriteLine($"superplayer score: {superPlayer.getscore()}, lives left: {superPlayer.GetLivesLeft()}");
