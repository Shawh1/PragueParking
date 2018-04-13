using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pargaue Parking");
            //Console.ReadLine();
            string[] stringArray = new string[100];
            
            
            //Console.WriteLine("Press 1 for Car, 2 for Motorcycel");
           // int vehicleType = Convert.ToInt32 (Console.ReadLine());
           // int index1 = Array.IndexOf(stringArray, 0);

            
          

            for (int i = 0; i <2; i++)
            {
                Console.Write("Take Reg number:");
                stringArray[i] = Console.ReadLine();
                Console.WriteLine("You car with reg number {0} for Car is parked at:{1}", stringArray[i], Array.IndexOf(stringArray, stringArray[i]));
            }

              Console.ReadLine();

           /* Console.Write("The free parking spaces are ");
            for (int i = 0; i < stringArray.Length; i++)
            {
                
                if (stringArray[i] == null)
                {
                    for (int j = 0; j < stringArray.Length; j++)
                        Console.Write("The free parking spaces are {0}", Array.IndexOf(stringArray, stringArray[i]
                        
            ));
                }
                Console.ReadLine();
            }
            Console.WriteLine("The Empaty parking spaces are");
           // Console.WriteLine("You Vehicle with reg number {0} for Car is parked at:{1}",str,Array.IndexOf(stringArray.);
            { 
            string regNumber = Console.ReadLine();
            if (vehicleType == 1)
            {
                stringArray[0] = regNumber;
                Console.WriteLine("You Enter reg number {0} for Car", regNumber);
            }
            else if (vehicleType == 2)
            {
                stringArray[0] = regNumber;
                Console.WriteLine("You Enter reg number {0} for MoterCycle", regNumber);
            }

            if (vehicleType == 1)
            {
                stringArray[1] = regNumber;
                Console.WriteLine("You Enter reg number {0} for Car", regNumber);
            }
            else if (vehicleType == 2)
            {
                stringArray[1] = regNumber;
                Console.WriteLine("You Enter reg number {0} for MoterCycle", regNumber);
            }
            

            Console.Write("The Car with Reg number {0} is parked at {1}",regNumber,Array.IndexOf(stringArray,regNumber));
            Console.ReadLine();*/
            
        }
    }
}
