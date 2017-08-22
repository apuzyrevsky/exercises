using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class MobilePhone
    {
        private string model { get; set; }
        private string manufacturer { get; set; }
        private string price { get; set; }
        private string owner { get; set; }
        public GSM gsm;
        private Battery battery;
        private Display display;


        public static MobilePhone nokiaN95 = new MobilePhone(model: "N95", manufacturer: "Nokia", price: "200$", owner: "Bill Gates");


        
        public MobilePhone(string model, string manufacturer, string price, string owner)
        {
         

            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            gsm = new GSM("Mark V");
            battery = new Battery("SS1488", "4300mAh");
            display = new Display("Foxcomm", "Retina", "4K");

           

        }
     

       public static void ShowNokiaN95()
        {

            Console.WriteLine(nokiaN95.model);
            Console.WriteLine(nokiaN95.manufacturer);
            Console.WriteLine(nokiaN95.price);
            Console.WriteLine(nokiaN95.owner);


        }
    }
  }
