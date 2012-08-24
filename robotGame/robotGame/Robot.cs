using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace robotGame
{
    public class Robot
    {
        private string name;
        private int tab;
        private int sejre;
        private int liv;
        private int draw;
        private int sizeOfList;
        private List<string> robotAtt = new List<string>();
        public List<string> robotDef = new List<string>();

        public Robot() { liv = 5; }

        public string getrobotName(){return name;}
        public void clearFields()
        {
            name = "";
            tab = 0;
            sejre = 0;
            liv = 0;
            draw = 0;
            robotAtt.Clear();
            robotDef.Clear();
        
        
        }

        public int getrobotLosses() { return tab; }

        public int getrobotWins() { return sejre; }

        public int getrobotDraws() { return draw; }

        public int getrobotLives() { return liv; }

        public List<string> getrobotAtt() { return robotAtt; }

        public List<string> getrobotDef() { return robotDef; }

        public void setRobotName(string newName) { name = newName; }

        public void setRobotLives(int newLiv) { liv = newLiv; }

        public void setRobotTab(int newTab) { tab = newTab; }

        public void setRobotSejre(int newSejre) { sejre = newSejre; }

        public void setRobotDraw(int newDraw) { tab = newDraw; }

        public int getAttack(int i) {
            
            return Convert.ToInt16(robotAtt[i]);
        }

        public int getDefence(int i) { return Convert.ToInt16(robotDef[i]); }

        public int numberOfRounds()
        {
            sizeOfList = robotAtt.Count();
            return sizeOfList;
        
        }
       
    }
}