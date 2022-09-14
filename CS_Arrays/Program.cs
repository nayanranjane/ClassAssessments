// Arrays in C Sharp


int[] numberArray = new int[10];
for (int i = 0; i < numberArray.Length; i++)
{
    numberArray[i] = i;
}



for (int i = 0; i < numberArray.Length; i++)
{
    Console.WriteLine(numberArray[i]);
}

string[] stringArray = new string[10];

for (int i = 0; i < numberArray.Length; i++)
{
    stringArray[i] = $"{i}. String Array";
}

for(int i = 0; i < stringArray.Length; i++)
{
    Console.WriteLine(stringArray[i]);
}
