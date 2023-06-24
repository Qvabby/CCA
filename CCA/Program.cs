using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CCA
{
    class Stats
    {
        private string _username;
        private string _character_name;
        private string _gender;
        private uint _age;
        private string _playstyle;

        public Stats(string username, string character_name, string gender, uint age, string playstyle)
        {
            _username = username;
            _character_name = character_name;
            _gender = gender;
            _age = age;
            _playstyle = playstyle;
        }
        public string GetUsername()
        {
            return _username;
        }
        public string GetCharacterName()
        {
            return _character_name;
        }
        public string GetGender()
        {
            return _gender;
        }
        public uint GetAge()
        {
            return _age;
        }
        public string GetPlaystyle()
        {
            return _playstyle;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //CHOOSING TO LOAD OR START OVER
            Console.WriteLine("1. Load\n2. Start Over");
            int LorSO;
            Console.Write("Your Choice(number): ");
            Console.ForegroundColor = ConsoleColor.Red;
            LorSO = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------\n\n");
            if (LorSO == 1)
            {
                // ====================IF YOU LOAD STATS ====================================================
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Work In Progress\n\n");
                Environment.Exit(0);
                //============================================================================================
            }
            else if (LorSO == 2)
            {
                // declaring ---------------------------------------------
                string username, character, gender, playstyle;
                uint age;
                // username ---------------------------------------------
                Console.Write("Input Username: ");
                Console.ForegroundColor = ConsoleColor.Red;
                username = Console.ReadLine();
                Console.ResetColor();
                // character name ---------------------------------------------
                Console.Write("Your character Name: ");
                Console.ForegroundColor = ConsoleColor.Red;
                character = Console.ReadLine();
                Console.ResetColor();
                // age ---------------------------------------------
                Console.Write("Your character Age: ");
                Console.ForegroundColor = ConsoleColor.Red;
                age = uint.Parse(Console.ReadLine());
                Console.ResetColor();
                // gender ---------------------------------------------
                Console.Write("Your character Gender (male/female): ");
                Console.ForegroundColor = ConsoleColor.Red;
                gender = Console.ReadLine();
                Console.ResetColor();
                // ------ gender misunderstanding ---------------------------------------------------------
                while (gender != "male" || gender != "Male" || gender != "female" || gender != "Female")
                {

                    if (gender == "male" || gender == "Male" || gender == "female" || gender == "Female")
                    {
                        break;
                    }
                    Console.Write("Your character Gender (male/female): ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    gender = Console.ReadLine();
                    Console.ResetColor();
                }
                //----------------------------------------------------------------------------------------

                // PlayStyle ---------------------------------------------
                do
                {
                    Console.Write("Your character PlayStyle (Warrior, Royal, Mage, Thief.): ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    playstyle = Console.ReadLine();
                    Console.ResetColor();
                    if (playstyle == "Warrior" || playstyle == "warrior" || playstyle == "Royal" || playstyle == "royal" || playstyle == "Mage" || playstyle == "mage" || playstyle == "Thief" || playstyle == "thief")
                    {
                        break;
                    }
                } while (playstyle != "Warrior" || playstyle != "warrior" || playstyle != "Royal" || playstyle != "royal" || playstyle != "Mage" || playstyle != "mage" || playstyle != "Thief" || playstyle != "thief");
                //--------------------------------------------------------------------------------------------------------------
                //==========================================
                //DECLEARING PLAYER STATSZ
                //==========================================
                Stats PL_Stats = new Stats(username, character, gender, age, playstyle);

                //-------------------------------Data work-------------------------------------------------
                bool Quit = false;

                //getting path
                string path, filename;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nEnter your \"exact\" folder path (Example - C://Users/user/Desktop/Folder): ");
                Console.ForegroundColor = ConsoleColor.Red;
                path = Console.ReadLine();
                Console.ResetColor();
                Console.Write("Enter your file Name(Example - CCADATA_1): ");
                Console.ForegroundColor = ConsoleColor.Red;
                filename = Console.ReadLine();
                filename = filename + ".txt";
                path = path + "/";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(path + filename);

                //creating data
                try
                {
                    TextWriter tw = new StreamWriter(path + filename, true);
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("action has been made.");
                    Console.ResetColor();
                    
                    //Game----------------------------------------------------------------------
                    while (true)
                    {
                        if (Quit == true)
                        {
                            Console.WriteLine("saving stats...");

                            //save username
                            tw.WriteLine($"Username, {PL_Stats.GetUsername()}");
                            //save character name
                            tw.WriteLine($"Character_Name, {PL_Stats.GetCharacterName()}");
                            //save gender
                            tw.WriteLine($"Gender, {PL_Stats.GetGender()}");
                            //save age
                            tw.WriteLine($"Age, {PL_Stats.GetAge()}");
                            //save playstyle
                            tw.WriteLine($"Playstyle, {PL_Stats.GetPlaystyle()}");
                            tw.Close();

                            Environment.Exit(0);
                        }
                        //menu
                        Quit = Menu(Quit);
                    }
                    



                }//if error
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(e);
                }




               
            }

            

        }

        /// <summary>
        /// Menu
        /// </summary>
        static dynamic Menu(bool quit)
        {
            Console.ResetColor();
            //declaring
            int m_c;
            string M_C;
            M_C = "No Choice";
            //--------
            Console.WriteLine("==============================================================\n\n-----------------Menu-------------------\n----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("----------------Game menu---------------\n1. Start/Continue the game              \n2. Shop                                 \n3. Location                             \n4. Current Quests                       \n--------------Settings menu-------------\n5. Settings                             \n6. Swiss da language                    \n7. Quit                                 \n----------------------------------------");
            Console.ResetColor();
            Console.Write("\nYour choice (input number): ");
            Console.ForegroundColor = ConsoleColor.Red;
            m_c = int.Parse(Console.ReadLine());
            //=============================================================================================
            //Converting int choice to string so we can read the shit out of code lmfao.------------------
            switch (m_c)
            {
                case 1:
                    {
                        M_C = "Play";
                        break;
                    }
                case 2:
                    {
                        M_C = "Shop";
                        break;
                    }
                case 3:
                    {
                        M_C = "Location";
                        break;
                    }
                case 4:
                    {
                        M_C = "Quests";
                        break;
                    }
                case 5:
                    {
                        M_C = "Settings";
                        break;
                    }
                case 6:
                    {
                        M_C = "Language";
                        break;
                    }
                case 7:
                    {
                        M_C = "Quit";
                        break;
                    }
                default:
                    break;
            }
            //Calling method to use menu choice
            return quit = M_CH(m_c, quit);
        }
        /// <summary>
        /// functions after reciving menu choice
        /// </summary>
        /// <param name="M_C">Menu choice here</param>
        static dynamic M_CH(int m_c, bool quit)
        {
            /// WHICH CHOICE DID U MAKE
            switch (m_c)
            {
                case 1:
                    {
                        PlayFunction();
                        return 0;
                        break;
                    }
                case 2:
                    {
                        ShopFunction();
                        return 0;
                        break;
                    }
                case 3:
                    {
                        LocationFunction();
                        return 0;
                        break;
                    }
                case 4:
                    {
                        QuestsFunction();
                        return 0;
                        break;
                    }
                case 5:
                    {
                        SettingsFunction();
                        return 0;
                        break;
                    }
                case 6:
                    {
                        LanguagesFunction();
                        return 0;
                        break;
                    }
                case 7:
                    {
                        quit = QuitFunction(quit);
                        return quit;
                        break;
                    }
                default:
                    return 0;
                    break;
            }
        }
        static void PlayFunction()
        {
            Console.WriteLine("You chose play");
        }
        static void ShopFunction()
        {
            Console.WriteLine("You chose Shopt");
        }
        static void LocationFunction()
        {
            Console.WriteLine("You chose Location");
        }
        static void QuestsFunction()
        {
            Console.WriteLine("You chose Quests");
        }
        static void SettingsFunction()
        {
            Console.WriteLine("You chose Settings");
        }

        static void LanguagesFunction()
        {
            Console.WriteLine("You chose Languages");
        }

        static bool QuitFunction(bool quit)
        {
            Console.WriteLine("You chose to Quit");
            Console.WriteLine("Are you sure?");
            Console.WriteLine("1 - yes | Any other number - no");
            int yesorno = int.Parse(Console.ReadLine());
            if (yesorno == 1)
            {
                quit = true;
                return quit;
            }
            return quit;
            
        }



    }
}

