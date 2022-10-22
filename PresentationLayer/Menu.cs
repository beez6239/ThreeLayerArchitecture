using System;
using System.Collections.Generic;
using System.Text;
using BussinessLogicLayer;
namespace PresentationLayer
{
   public class Menu
   {
        Variables Varia = new Variables();
        public void details1()
        {
            var det = new Variables()
            {
                FirstName = "Sam",
                LastName = "Mike",
                ID = "73822",
                PassID = "A1232",
                AverageScore = 50,
                StudyYear = 2002

            };
            
        }
        //public void deci()
        //{ 
            
        //    Console.WriteLine("Do you wish to use the xml ??");
        //    Varia.quest = Console.ReadLine();


        //    if (Varia.quest == "Yes" || Varia.quest == "yes")
        //    {

        //    }
        //}
   }
}
