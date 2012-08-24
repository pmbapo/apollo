using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace robotGame
{
    public class game
    {

        private Robot robotOne;
        private Robot robotTwo;


        public game()
        {

            robotOne = new Robot();
            robotTwo = new Robot();
        }


        public void fight(Robot a, Robot b)

      {
          int x = 0;
          x = a.numberOfRounds();
            for (int i = 0; i < x; i++)
            {
                if (a.getAttack(i) != b.getDefence(i))  // robot 1 wins a life
                {
                    aWin(a, b);
                }

                if (b.getAttack(i) != a.getDefence(i))  // robot 2 wins
                {
                    aWin(b, a);
                }

                if (b.getAttack(i) == a.getDefence(i))  // robot 2 wins
                {
                    aDraw(a, b);
                }




            }
        
        
        }

        public void aWin(Robot a, Robot b)
        {
            //increase robot wins
            int wins, losses, lives = 0;
            wins = a.getrobotWins();
            wins++;
            a.setRobotSejre(wins);

            //increase robot lives
            lives = a.getrobotLives();
            lives++;
            a.setRobotLives(lives);


            //Decrease robot lives
            losses = b.getrobotLosses();
            losses--;
            b.setRobotTab(losses);
        
        }

        public void aDraw(Robot a, Robot b)
        {
            //increase robot draws
            int draws1 = 0;
            draws1 = a.getrobotDraws();
            draws1++;
            a.setRobotDraw(draws1);

            //increase robot draws
            int draws2 = 0;
            draws2 = b.getrobotDraws();
            draws2++;
            b.setRobotDraw(draws2);
        }
    }
}