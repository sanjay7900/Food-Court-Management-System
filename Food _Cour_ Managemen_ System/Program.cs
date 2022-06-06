using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food__Cour__Managemen__System
{
    internal class Program
    {
        private static void menu()
        {
            Console.WriteLine("Press 1 : for The Manage Food Items");
            Console.WriteLine("Press 2 : for the Manage the Category ");
            Console.WriteLine("Press 3 : for the Manage the sales");
            Console.WriteLine("Press 4: for the Reports Of The Project Food Court Management System");

            Console.WriteLine("Press 5 : exit");
            Console.Write("                                                     ");
        }
        static void Main(string[] args)
        {
            ManageFoodCategory manageFoodCategory = new ManageFoodCategory();
            ManageSales manageSales = new ManageSales();    
            ManageFoodItems manageFoodItems=new ManageFoodItems();
            ReportsOfTheProjectFoodCourtManagementSystem reportsOfTheProjectFoodCourtManagementSystem=new ReportsOfTheProjectFoodCourtManagementSystem();
        mainmenu:
            menu();


            int choisedata=Convert.ToInt32(Console.ReadLine());
            switch(choisedata)
            {
                case 1:
                    manageFoodItems.PerformAction();
                    goto mainmenu;
                    case 2:
                    manageFoodCategory.PerformAction();
                    goto mainmenu;
                case 3:
                    manageSales.PerformAction();
                    goto mainmenu;
                case 4:
                    reportsOfTheProjectFoodCourtManagementSystem.performAction();
                    goto mainmenu;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("wring choise");
                    goto mainmenu;

            }

            Console.ReadLine(); 
        }
    }
}
