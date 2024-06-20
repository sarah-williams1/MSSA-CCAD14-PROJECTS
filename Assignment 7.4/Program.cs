using System.ComponentModel.Design;

namespace Assignment_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Parking Lot. Please type either 1, 2, or 3 for your car type.");
            Console.WriteLine("For a big car, press 1:\nFor a medium car, press 2\nFor a small car, press 3.");
         

            int carType = int.Parse(Console.ReadLine());
            ParkingSystem parkingSystem = new ParkingSystem(30, 40, 50);
            bool result = parkingSystem.AddCar(carType);

            if (result == false)
            {
                Console.WriteLine("Entry Not Authorized");
            }

        }
    }


    public class ParkingSystem
    {
        int bigSpotsAvailable;
        int mediumSpotsAvailable;
        int smallSpotsAvailable;

        
        public ParkingSystem(int big, int medium, int small)
        {
                                                                // Adds the quantity of parking spots available for each car type.
            bigSpotsAvailable = big;
            mediumSpotsAvailable= medium;
            smallSpotsAvailable = small;
            
        }
        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:                                         // Big car. If spots available is greater than 0, then it will return true and subtract 1
                    if (bigSpotsAvailable > 0)
                    {
                        bigSpotsAvailable--;
                        Console.WriteLine("Entry granted. " + bigSpotsAvailable + " spots remaining");
                        return true;
                    }
                    break;
                case 2:                                         // Medium car. If spots available is greater than 0, then it will return true and subtract 1
                    if (mediumSpotsAvailable > 0)
                    {
                        mediumSpotsAvailable--;
                        Console.WriteLine("Entry granted. " + mediumSpotsAvailable + " spots remaining");
                        return true;
                    }
                    break;
                case 3:                                         // Small car. If spots available is greater than 0, then it will return true and subtract 1
                    if (smallSpotsAvailable > 0)
                    {
                        smallSpotsAvailable--;
                        Console.WriteLine("Entry granted. " + smallSpotsAvailable + " spots remaining");
                        return true;
                    }
                    break;
                default:
                    return false;                               // If the user inputs an incorrect number then it will return false
            }
            return false;                                       // If there are no spots available then it will return false. 
        }
    }
}


/*
 * design a parking lot system that has 3 kinds of spaces: small, medium, and big with a fixed amount for each.
 * Implement the ParkingSystem class.
 * Parking system(int big, int medium, int small) initializes object of the ParkingSystem class.
 * bool addCar(int carType) checks whether there is a parking space of carType for the car that wants to park in the lot
 * carType is represented by 1, 2, and 3 (big, medium, small).
 * If no space is available, return false, else true.
 */ 