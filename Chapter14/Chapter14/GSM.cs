using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class GSM
    {
        string model { get; set; }

        //internal List<Call> CallHistory
        //{
        //    get
        //    {
        //        return callHistory;
        //    }

        //    set
        //    {
        //        callHistory = value;
        //    }
        //}

        List<Call> callHistory = new List<Call>();

        public GSM(string model)
        {
            this.model = model;
        }


        public void PrintInfo()
        {
            Console.WriteLine("Here is some data about your GSM module:");
        }

        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            callHistory.Remove(call);
        }
        
        public void DeleteAllCalls()
        {
            foreach (var call in callHistory)
            {
                callHistory.Remove(call);
            }
        }

        public void CalculatePriceOfCalls(double price)
        {
            int amount = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                amount++;
            }
            double totalPrice = amount * price;
            Console.WriteLine("The price of all calls is {0} $", totalPrice);
        }


    }
}
