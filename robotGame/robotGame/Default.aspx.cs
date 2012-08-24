using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;

namespace robotGame
{
    public partial class _Default : System.Web.UI.Page
    {
        
        private Robot aRobot1 = new Robot();
        private Robot aRobot2 = new Robot();

        public List <string> itemsAtt = new List<string>();
        public List<string> itemsDef = new List<string>();
        private game aGame = new game();
        


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void loadRobot1()
        {
            aRobot1.clearFields();
            //StringBuilder strB = new StringBuilder("<b>Using XML Reader</b> <br />", 500);
            XmlTextReader reader = new XmlTextReader("C:/apollo/notepad++Files/robot1.xml");
            reader.WhitespaceHandling = WhitespaceHandling.None; // dont read the white spaces
            try
            {
                //  Loop over the XML file
                while (reader.Read())
                {
                      //  Here we check the type of the node, in this case we are looking for element
                      if (reader.NodeType == XmlNodeType.Element)
                     {
                               if (reader.Name == "navn")
                               {
                                reader.Read();
                                //navn1 = reader.Value;
                                aRobot1.setRobotName(reader.Value);
                                reader.Read();
                                reader.Read();
                                reader.Read();
                               }
        
                       //  If the element is "runde"
                              if (reader.Name == "runde")
                               {
                            //  Add the attribute value of "skjold" to the listbox
                                   aRobot1.getrobotAtt().Add(reader.GetAttribute("skjold"));
                                  //itemsAtt.Add(reader.GetAttribute("vaaben"));
                                   aRobot1.getrobotDef().Add(reader.GetAttribute("vaaben"));
                                  //itemsDef.Add(reader.GetAttribute("vaaben"));
                              }

                          //  If the element is "tab"                  
                          if (reader.Name == "tab")
                             {
                                 reader.Read();//continue reading to get to the value
                                 aRobot1.setRobotTab(Convert.ToInt16(reader.Value));
                                 //tab = Convert.ToInt16(reader.Value);
                             }

                          if (reader.Name == "sejre")
                          {
                              reader.Read();//continue reading to get to the value
                              aRobot1.setRobotSejre(Convert.ToInt16(reader.Value));
                              //tab = Convert.ToInt16(reader.Value);
                          }

                          if (reader.Name == "uafgjort")
                          {
                              reader.Read();//continue reading to get to the value
                              aRobot1.setRobotDraw(Convert.ToInt16(reader.Value));
                              //tab = Convert.ToInt16(reader.Value);
                          }
                    }
                }
 
                //reader.Close();
                 }
                    catch
                        {
                             throw;
                         }
                    finally
                    {
                reader.Close();
            }
        }



        private void loadRobot2()
        {
           aRobot2.clearFields();
            //StringBuilder strB = new StringBuilder("<b>Using XML Reader</b> <br />", 500);
            XmlTextReader reader = new XmlTextReader("C:/apollo/notepad++Files/robot2.xml");
            reader.WhitespaceHandling = WhitespaceHandling.None; // dont read the white spaces
            try
            {
                //  Loop over the XML file
                while (reader.Read())
                {
                    //  Here we check the type of the node, in this case we are looking for element
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "navn")
                        {
                            reader.Read();
                            //navn1 = reader.Value;
                            aRobot2.setRobotName(reader.Value);
                            reader.Read();
                            reader.Read();
                            reader.Read();
                        }

                        //  If the element is "runde"
                        if (reader.Name == "runde")
                        {
                            //  Add the attribute value of "skjold" to the listbox
                            aRobot2.getrobotAtt().Add(reader.GetAttribute("skjold"));
                            //itemsAtt.Add(reader.GetAttribute("vaaben"));
                            aRobot2.getrobotDef().Add(reader.GetAttribute("vaaben"));
                            //itemsDef.Add(reader.GetAttribute("vaaben"));
                        }

                        //  If the element is "tab"                  
                        if (reader.Name == "tab")
                        {
                            reader.Read();//continue reading to get to the value
                            aRobot2.setRobotTab(Convert.ToInt16(reader.Value));
                            //tab = Convert.ToInt16(reader.Value);
                        }

                        if (reader.Name == "sejre")
                        {
                            reader.Read();//continue reading to get to the value
                            aRobot2.setRobotSejre(Convert.ToInt16(reader.Value));
                            //tab = Convert.ToInt16(reader.Value);
                        }

                        if (reader.Name == "uafgjort")
                        {
                            reader.Read();//continue reading to get to the value
                            aRobot2.setRobotDraw(Convert.ToInt16(reader.Value));
                            //tab = Convert.ToInt16(reader.Value);
                        }
                    }
                }

                //reader.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                reader.Close();
            }
        }


        public void displayRobots1()
        {
            itemsAtt.Clear();
            itemsDef.Clear();
            itemsAtt = aRobot1.getrobotAtt();
            itemsDef = aRobot1.getrobotDef();

            for (int i = 0; i < itemsAtt.Count(); i++)
                TextBox1.Text += itemsAtt[i] +"  :  " + itemsDef[i] + "\r\n";
        
        
        }

        public void displayRobots2()
        {
           //itemsAtt.Clear();
            //itemsDef.Clear();
            itemsAtt = aRobot2.getrobotAtt();
            itemsDef = aRobot2.getrobotDef();

            for (int i = 0; i < itemsAtt.Count(); i++)
                TextBox2.Text += itemsAtt[i] + "  :  " + itemsDef[i] + "\r\n";


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        //load the robots
        protected void Button1_Click(object sender, EventArgs e)
        {
            loadRobot1();
            displayRobots1();
            loadRobot2();
            displayRobots2();

            aGame.fight(aRobot1, aRobot2);


            TextBox3.Text += "RESULTS " + aRobot1.getrobotLosses() + "lives" + "\r\n";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            aGame.fight(aRobot1, aRobot2);
            
            
            TextBox3.Text += "RESULTS " + aRobot1.getrobotLives() + "lives" + "\r\n";

           //  TextBox3.Text += "Robot 1 has finished with:" + aGame.


        }
    }
    
}
