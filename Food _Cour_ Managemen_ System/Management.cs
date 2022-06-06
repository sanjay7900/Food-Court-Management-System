using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Food__Cour__Managemen__System
{
    public interface Management
    {
        

         void AddnewItem(string filename,ArrayList arrayList); 
         void RemoveItem(int id,string filename);
         void UpdateExistItem(int id,string name,ArrayList arrayList ,string filename);
         void ListAllItem(string filename);
        void ViewDetailsOfItems(int id,string name, string filename);


    }
}
