

string string1 = "India is my country";

string string2 = "All Indians are my bother and sister";

Console.WriteLine(string1);

Console.WriteLine(string2);

string concatinatedString = string1 + "   "+string2;

Console.WriteLine(concatinatedString);

concatinatedString += " "+ string1 + "   " + string2;

Console.WriteLine(concatinatedString);


for(int i = 0; i < concatinatedString.Length; i++)
{
    Console.WriteLine(concatinatedString[i]);
}
