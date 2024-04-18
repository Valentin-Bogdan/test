public static class Program
{
    public static void Main()
    {
        //Declare strings
        string myFirstString = "Hello World!";
        Console.WriteLine(myFirstString);

        int myNumber = 42;
        Console.WriteLine(myNumber);

        string myNumberAsString = myNumber.ToString();

        string firstName = "Ionel";
        string lastName = "Popescu";
        string fullName = firstName + " " +lastName;

        string fullNameWithConcat = String.Concat(firstName, " ", lastName);
        Console.WriteLine(fullNameWithConcat);
        Console.WriteLine($"{firstName} {lastName} ");

        //Searching in strings 

        int index = fullName.IndexOf("Io");
        Console.WriteLine(index);
        index = fullName.IndexOf("Popescu");
        Console.WriteLine(index);
        index = fullName.IndexOf("POPESCU"); 
        Console.WriteLine(index);
        index = fullName.IndexOf("o",2);
        Console.WriteLine(index);

        //Extract substring

        string path = "C:/Holiday/2025/1/nice_pic.png";

        // search the dot in string
        int indexofDot = path.IndexOf(".");

        //take the file extension

        string extention = path.Substring(indexofDot + 1);
        Console.WriteLine(extention);

        //extract the file name
        int lastIndexOfSlash = path.LastIndexOf('/');
        int substringLenght = indexofDot - lastIndexOfSlash - 1;

        string fileName =path.Substring(lastIndexOfSlash + 1, substringLenght);
        Console.WriteLine($"{fileName}.{extention}");



    }
}