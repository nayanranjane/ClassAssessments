string input = Console.ReadLine();

var inputArray = input.Split(" ");

string[] arrayInput = new string[5];
if(inputArray.Length > 5)
{
    Console.WriteLine("Enter the correct string");
    input = Console.ReadLine();
    arrayInput= input.Split(" ");
}
int[] intArray = new int[5];

for(int i = 0; i < intArray.Length; i++)
{
    intArray[i] = Convert.ToInt32(arrayInput[i]);
}
Array.Sort(intArray);
Console.WriteLine(intArray[0]);
Console.WriteLine(intArray[1]);
Console.WriteLine(intArray[2]);
