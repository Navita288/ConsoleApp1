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
            //TODD
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

        public void Launch()
        {
            Maple.villageName = "Maple";
            Maple.nextvillage = Toronto;
            Maple.previousvillage = null;
            Toronto.villageName = "Toronto";
            Toronto.nextvillage = Ajax;
            Toronto.previousvillage = Maple;
            Ajax.villageName = "Ajax";
            Ajax.nextvillage = null;
            Ajax.nextvillage = Toronto;
        }
    }
}

