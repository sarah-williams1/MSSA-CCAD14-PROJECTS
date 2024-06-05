namespace Assignment_5._3._1_Flower_Pots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flowers cannot be planted in adjacent pots. 0 means the flower pot is empty, and 1 means the flower pot is full.");
            int[] flowerBedArray = { 1, 0, 0, 0, 1 };
            int length = flowerBedArray.Length;
            int flowerPots = FlowerPlacement(flowerBedArray);
            Console.Write("The number of flowers you'd like to plant are: ");
            Console.WriteLine(flowerPots);


        }

        public bool FlowerPlacement(int[] flowerBedArray, int length)
        {
            var count = 0;

            for (int i = 0; i < length; i++)
            {

                if (flowerBedArray[i] == 0 && (i == 0 || flowerBedArray[i - 1] == 0) && (i == length - 1 || flowerBedArray[i + 1] == 0))
                {
                    flowerBedArray[i++] = 1;
                    count++;
                }
                if (count >= i)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            return count >= length;
        }
    }
}
