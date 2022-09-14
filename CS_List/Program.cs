
List<int> integerList = new List<int>() { 123,23334,223,2345,235,645};

// We can Add item by Add method


integerList.Add(2000);
integerList.Add(543);


integerList.AddRange(new int[4] { 1,2,3,4});

foreach(var integer in integerList)
{
    Console.WriteLine(integer);
}

