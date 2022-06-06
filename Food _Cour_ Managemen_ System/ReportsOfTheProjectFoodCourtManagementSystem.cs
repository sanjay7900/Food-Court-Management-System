using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food__Cour__Managemen__System
{
    public class ReportsOfTheProjectFoodCourtManagementSystem:SomeCommanFeiled
    {
        public void performAction()
        {
        upper:
            menu();
            int choise =Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    ListAllItem(@"D:\aspdotnet\CSharpOPPsRepo\Food _Cour_ Managemen_ System\fooditem.txt");
                    goto upper;
                  case 2:
                    ListAllItem(@"D:\aspdotnet\CSharpOPPsRepo\Food _Cour_ Managemen_ System\category.txt");
                    goto upper;
                case 3:
                    ListAllItem(@"D:\aspdotnet\CSharpOPPsRepo\Food _Cour_ Managemen_ System\sales.txt");
                    goto upper;
                case 4:
                    break;
                default:
                    Console.WriteLine("Wrong Choise ");
                    goto upper;

            }
           

        }
        private void menu()
        {
            Console.WriteLine("Press 1 : for The Show Reports Of FoodItems ");
            Console.WriteLine("Press 2 : for the Show Reports of food category ");
            Console.WriteLine("Press 3 : for the Show Reports of sales");

            Console.WriteLine("Press 4 : Goto OutSide");
            Console.Write("                                                     ");
        }
    }
}
