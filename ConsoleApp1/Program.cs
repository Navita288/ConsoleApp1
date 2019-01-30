using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730283
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside blue = new Countryside();
            blue.Launch();
        }
    }
    class village
    {
        public village nextvillage;
        public village previousvillage;
        public string villageName;
        public bool isAstrildeHere = false;

    }
    class Countryside
    {
        village Maple = new village();
        village Toronto = new village();
        village Ajax = new village();
        village First;
        village Last;
        village temp;
       

        public void Launch()
        {
            
             First = Maple;
             Last = Ajax;
            Maple.villageName = "Maple";
            Maple.nextvillage = Toronto;
            Maple.previousvillage = null;
            Toronto.villageName = "Toronto";
            Toronto.nextvillage = Ajax;
            Toronto.previousvillage = Maple;
            Ajax.villageName = "Ajax";
            Ajax.nextvillage = null;
            Ajax.nextvillage = Toronto;

           Console.WriteLine(this.displayMap());
        }

        public string displayMap()
        {
            string listofCities = "";
            // we need to print all cities in our area

            
                listofCities = listofCities + First.villageName + "----";
                temp = First.nextvillage;
            listofCities = listofCities + temp.villageName + "----";


            return listofCities;

        }
    }
}

