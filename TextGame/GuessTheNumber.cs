using System;

namespace TextGame
{
    class GuessTheNumber
    {
        static void Main(string[] args)
        {
            // Do you want to play?
            Console.WriteLine("Hello! Wanna play a simple fun game? (Yes/No)");
            string a = Console.ReadLine();
            a = a.ToLower();
            // Yes, I want to play
            if (a == "yes")
            {
                //Have you played before?
                Console.WriteLine("Awesome! So, have you played this game before?");
                string b = Console.ReadLine();
                b = b.ToLower();
                //Yes I have played before
                if (b == "yes")
                {
                    Console.WriteLine("Let's get to it then!");
                    RunGame();
                }
                //No I'm new
                else if (b == "no")
                {
                    //Explaining,ready?
                    Console.WriteLine("Alright, let me explain. I will think of a random number from 1 to 100, your goal is to guess the number! You can ask whether it's nicely dividable by some number like 2, 3, 5 and so on by typing: ,Wanna divide,. After typing this comand you'll be able to type the number you'd like to try and I'll tell you whether it is dividable by the number you suggested! To stop guessing the numbers used to divide my number type ,Back,. If you'll think you know which number I'm thinking of simply type: ,Wanna guess, and you'll be able to guess directly! To stop guessing you can again type ,Back,! If the number will be incorrect I'll hint you whether my number is smaller or bigger than your guess! Now that you know the mechanics we can play! Ready?");
                    string c = Console.ReadLine();
                    c = c.ToLower();
                    //Yes, ready to play
                    if (c == "yes")
                    {
                        RunGame();
                    }
                    //No not ready
                    else if (c == "no")
                    {
                        //Ready?
                        Console.WriteLine("Alright, take all the time you need, once you're ready to play type: ,I'm ready, and the game will start, if you don't want to play right now, just type: ,Stop,.");
                        string d = Console.ReadLine();
                        d = d.ToLower();
                        //Ready
                        if (d == "i'm ready" || d == "im ready")
                        {
                            RunGame();
                        }
                        //Stop
                        else if (d == "stop")
                        {
                            Console.WriteLine("Oh, alright. Come play some other time!");
                        }
                        //Wrong input
                        else
                        {
                            Console.WriteLine("Try opening the game again if you want to play!");
                        }
                    }
                    //Wrong input
                    else
                    {
                        //Ready again?
                        Console.WriteLine("I don't understand, are you ready to play the game? (Yes/No)");
                        string b1 = Console.ReadLine();
                        b1 = b1.ToLower();
                        //Yes
                        if (b1 == "yes")
                        {
                            RunGame();
                        }
                        //No
                        else if (b1 == "no")
                        {
                            Console.WriteLine("Huh, that's a shame... but if you'll ever be down to play just come back and we'll play as long as you'll want!");
                        }
                        //Wrong input 2x
                        else
                        {
                            Console.WriteLine("Try opening the game again if you want to play!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter Yes/No, please!");
                    RunGame();
                }
            }
            //No I don't want to play
            else if (a == "no")
            {
                Console.WriteLine("Huh, that's a shame... but if you'll ever be down to play just come back and we'll play as long as you'll want!");
            }
            //Wrong input
            else
            {
                Console.WriteLine("I have no idea what you mean, please, answer the question. Do you want to play a game? (Yes/No)");
                string a1 = Console.ReadLine();
                a1 = a1.ToLower();
                //Yes
                if (a1 == "yes")
                {
                    Console.WriteLine("Alright, let me explain. I will think of a random number from 1 to 100, your goal is to guess the number! You can ask whether it's nicely dividable by some number like 2, 3, 5 and so on by typing: ,Wanna divide,. After typing this comand you'll be able to type the number you'd like to try and I'll tell you whether it is dividable by the number you suggested! To stop guessing the numbers used to divide my number type ,Back,. If you'll think you know which number I'm thinking of simply type: ,Wanna guess, and you'll be able to guess directly! To stop guessing you can again type ,Back,! If the number will be incorrect I'll hint you whether my number is smaller or bigger than your guess! Now that you know the mechanics we can play! I have my number, now guess!");
                    RunGame();
                }
                //No
                else if (a1 == "no")
                {
                    Console.WriteLine("Huh, that's a shame... but if you'll ever be down to play just come back and we'll play as long as you'll want!");
                }
                //Wrong input 2x
                else
                {
                    Console.WriteLine("Try opening the game again if you want to play!");
                }
            }
        }
        public static void RunGame()
        {
            Console.WriteLine("A number, huh,..... that's the right one! Now guess which number it is! (Wanna guess/Wanna divide)");
            Random a = new Random();
            int random_number = a.Next(1, 100);
            int END = 0;
            while(END == 0)
            {
                string c = Console.ReadLine();
                c = c.ToLower();
                if (c == "stop")
                {
                    END = END++;
                }
                else if (c == "wanna divide")
                {
                    Console.WriteLine("Alright, what number would you like to ask about? You can quit asking by typing ,Back,!");
                    int back1 = 0;
                    while (back1 == 0)
                    {
                        string d = Console.ReadLine();
                        bool StringOrNot = int.TryParse(d, out int guess_division);
                        string back = d.ToLower();
                        if (back == "back" && StringOrNot == false)
                        {
                            back1 = 1;
                            Console.WriteLine("You can use the, Wanna guess, and, Wanna divide, commands again!");
                        }
                        else if (StringOrNot == true)
                        {
                            if (guess_division < 0)
                            {
                                Console.WriteLine("That's too small, only positive numbers work!");
                            }
                            else if (guess_division > 0 && guess_division < 51)
                            {
                                if (guess_division == 1)
                                {
                                    Console.WriteLine("Every number is dividable by 1! Try some other number!");
                                }
                                else if (random_number % guess_division == 0)
                                {
                                    Console.WriteLine("Yes! It is dividable by " + guess_division + "! You're one step closer to guessing the number!");
                                }
                                else
                                {
                                    Console.WriteLine("Nope, try other number or try to guess the mysterious number!");
                                }
                            }
                            else if (guess_division > 100)
                            {
                                Console.WriteLine("That's way too big! Try a number smaller than 100!");
                            }
                        }
                    }
                }
                else if (c == "wanna guess")
                {
                    Console.WriteLine("Alright, try to guess my un-guessable number if you dare! You can quit guessing by typing ,Back,!");
                    int back2 = 0;
                    while (back2 == 0)
                    {
                        string f = Console.ReadLine();
                        bool StringOrNot1 = int.TryParse(f, out int guess);
                        string back_1 = f.ToLower();
                        if (back_1 == "back" && StringOrNot1 == false)
                        {
                            back2 = 1;
                            Console.WriteLine("You can use the ,Wanna guess, and ,Wanna divide, commands again!");
                        }
                        if (StringOrNot1 == true)
                        {
                            if (random_number == guess)
                            {
                                Console.WriteLine("Congratulations! You guessed the un-guessable! Wanna play again? (Yes/No)");
                                string playagain = Console.ReadLine();
                                string playagain1 = playagain.ToLower();
                                if (playagain1 == "yes")
                                {
                                    RunGame();
                                }
                                else
                                {
                                    END = END++;
                                }
                            }
                            else
                            {
                                if (random_number < guess)
                                {
                                    Console.WriteLine("No, my number is smaller, try again!");
                                }
                                if (random_number > guess)
                                {
                                    Console.WriteLine("No, my number is bigger, try again!");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Keep trying! Guess my number and win the game, or type ,Stop, to stop playing!");
                }
            }
        }
    }
}
