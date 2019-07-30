using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_Movie_List
{
    class Continue
    {
        public static bool ContinueOrNot()
        {
            bool cont = true;
            bool result = true;
            while(cont)
            {
                string userInput = Console.ReadLine().ToLower();
                if(userInput == "y")
                {
                    result = true;
                    cont = false;
                }
                else if(userInput == "n")
                {
                    result = false;
                    cont = false;
                }
                else
                {
                    continue;
                }
            }
            return result;
        }
    }
}
