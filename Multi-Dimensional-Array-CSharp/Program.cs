//Multi Dimensional Array in CSharp
Console.WriteLine("Multi-Dimensional Array::");


int[,,] intArray = new int[3, 4, 3]

{
    {
        {1,2,3}, {4,5,6}, {7,8,9}, {10,11,12}
    },
    {
        {00,01,02}, {03,04,05}, {06,07,08}, {09,10,11}
    },

    {   {1,2,3}, {4,5,6}, {7,8,9}, {10,11,12}

    }

};
Console.WriteLine("First Row Data::");
Console.WriteLine(intArray[0, 0, 0] + "  " + intArray[0, 0, 1] + "  " + intArray[0, 0, 2]);
Console.WriteLine(intArray[0, 1, 0] + "  " + intArray[0, 1, 1] + "  " + intArray[0, 1, 2]);
Console.WriteLine(intArray[0, 2, 0] + "  " + intArray[0, 2, 1] + "  " + intArray[0, 2, 2]);
Console.WriteLine(intArray[0, 3, 0] + " " + intArray[0, 3, 1] + " " + intArray[0, 3, 2]);


Console.WriteLine("Second Row Data::");
Console.WriteLine(intArray[1, 0, 0] + " " + intArray[1, 0, 1] + " " + intArray[1, 0, 2]);
Console.WriteLine(intArray[1, 1, 0] + " " + intArray[1, 1, 1] + " " + intArray[1, 1, 2]);
Console.WriteLine(intArray[1, 2, 0] + " " + intArray[1, 2, 1] + " " + intArray[1, 2, 2]);
Console.WriteLine(intArray[1, 3, 0] + " " + intArray[1, 3, 1] + " " + intArray[1, 3, 2]);

Console.WriteLine("Third Row Data::");
Console.WriteLine(intArray[2, 0, 0] + " " + intArray[2, 0, 1] + " " + intArray[2, 0, 2]);
Console.WriteLine(intArray[2, 1, 0] + " " + intArray[1, 1, 1] + " " + intArray[2, 1, 2]);
Console.WriteLine(intArray[2, 2, 0] + " " + intArray[2, 2, 1] + " " + intArray[2, 2, 2]);
Console.WriteLine(intArray[2, 3, 0] + " " + intArray[2, 3, 1] + " " + intArray[2, 3, 2]);