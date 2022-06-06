using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Food__Cour__Managemen__System
{
    public class ManageFoodCategory : SomeCommanFeiled
    {
        ArrayList arrayList=new ArrayList();    
        public void PerformAction()
        {
            AgainAndAgain:
            menu();
            int choise=Convert.ToInt32(System.Console.ReadLine());
            switch (choise)
            {
                case 1:
                    addmore:
                    Console.Write(" Enter the new category id ");
                    int newcatid=Convert.ToInt32(System.Console.ReadLine());
                    Console.Write("Enter the New category name ");
                    string newcatname=Console.ReadLine();
                    string date = DateTime.Now.ToString();
                    arrayList.Add(newcatid);
                    arrayList.Add(newcatname);
                    arrayList.Add(date);
                    AddnewItem(@"D:\aspdotnet\CSharpOPPsRepo\Food _Cour_ Managemen_ System\category.txt", arrayList);
                    arrayList.Clear();  
                    Console.Write(" Do you Want more Press 1:");
                    int check=Convert.ToInt32(Console.ReadLine());
                    if (check == 1)
                    {
                        goto addmore;
                    }
                    goto AgainAndAgain;
                case 2:
                    Console.Write("Enter the category id To Show Of Its Details : ");
                    int showcatid=Convert.ToInt32(Console.ReadLine());  
                    Console.Write("Enter the category name To Show Of Its Details : ");
                    string showcatname=Console.ReadLine();
                    ViewDetailsOfItems(showcatid, showcatname, @"D:\aspdotnet\CSharpOPPsRepo\Food _Cour_ Managemen_ System\category.txt");
                    goto AgainAndAgain;
                case 3:
                    ListAllItem(@"D:\aspdotnet\CSharpOPPsRepo\Food _Cour_ Managemen_ System\category.txt");
                    goto AgainAndAgain;
                case 4:
                    updatemore:
                    Console.Write("Enter the   category id To update Of Its Details : ");
                    int updatecatid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the  category name To update Of Its Details : ");
                    string updatecatname = Console.ReadLine();
                    ViewDetailsOfItems(updatecatid, updatecatname, @"D:\aspdotnet\CSharpOPPsRepo\Food _Cour_ Managemen_ System\category.txt");
                    Console.Write("Enter the new Name Of its Above Category : ");
                    string updatename=Console.ReadLine();   
                    string date2 =DateTime.Now.ToString();
                    arrayList.Add(updatecatid);
                    arrayList.Add(updatename);
                    arrayList.Add(date2);
                    UpdateExistItem(updatecatid, updatecatname, arrayList, @"D:\aspdotnet\CSharpOPPsRepo\Food _Cour_ Managemen_ System\category.txt");
                    arrayList.Clear();
                    Console.Write(" Do you Want more Press 1:");
                    int check2 = Convert.ToInt32(Console.ReadLine());
                    if (check2 == 1)
                    {
                        goto updatemore;
                    }
                    goto AgainAndAgain;



                case 5:
                    break;
                default:
                    Console.WriteLine(" wrong Choise ");
                    goto AgainAndAgain;





            }
                
        }
        private void menu()
        {
            Console.WriteLine("Press 1 : for The Add New Category ");
            Console.WriteLine("Press 2 : for the Show Details Of category ");
            Console.WriteLine("Press 3 : for the Show List Of All cateGory ");
            Console.WriteLine("Press 4 : Update The Exist category ");
            Console.WriteLine("Press 5 : Goto OutSide");
            Console.Write("                                                     ");
        }

       
    }
}
