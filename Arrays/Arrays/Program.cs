namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare new array
            int[] myArray = new int[3]; //size of the array
            myArray[0] = 35;
            myArray[1] = -10;
            myArray[2] = 20;
            // this will throw index out of range exception 
            myArray[1] = 9434; 

            string[] daysOfTheWeek =  { "Luni", "Marti", "Joi", "Sambata" };

            //accessing elements from an array

            string[] reversedDays = new string[6];

            for(int i = 0; i < daysOfTheWeek.Length; i++)
            {
                reversedDays[daysOfTheWeek.Length -i -1] = daysOfTheWeek[i];
            }

            Console.WriteLine(reversedDays[0]);

            // for loop

            for (int i=0; i < daysOfTheWeek.Length; i++)
            {
                Console.WriteLine(daysOfTheWeek[i]);
            }

            //foreach
            foreach (string item in daysOfTheWeek)
            {
                Console.WriteLine(item);
            }

            //while
            int index = 0;
            while (index < daysOfTheWeek.Length)
            {
                Console.WriteLine(daysOfTheWeek[index]);
                index++;
            }

            index =0;
            do
            {
                Console.WriteLine(daysOfTheWeek[index]);
                index++;
            } while (index < daysOfTheWeek.Length);

            // Read array from Console 

            Console.WriteLine("Please give an array size:");
            int arraySize = int.Parse(Console.ReadLine());

            int[] myArrayFromConsole = new int[arraySize];

            Console.WriteLine("Please input the values of the array:");
            for (int i = 0; i< arraySize; i++)
            {
                myArrayFromConsole[i] = int.Parse(Console.ReadLine());
            }

            string[] myArrayCopy = daysOfTheWeek;  // nu se copiaza asa deoarece ambele stringuri vor face referinta catre acelasi obiect din memorie

            myArrayCopy[0] = "alabaa";
            Console.WriteLine(myArrayCopy[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            string[] myArrayClone = (string[]) daysOfTheWeek.Clone();
            myArrayClone[0] = "Duminica";
            Console.WriteLine(myArrayClone[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            int[] intArray = new int[5];
            int[] copyArray = intArray;
            intArray = new int[6];
            for (int i = 0;i< copyArray.Length;i++)
            {
                intArray[i] = copyArray[i];
            }

            intArray[5] = 10;

        }
    }
}
