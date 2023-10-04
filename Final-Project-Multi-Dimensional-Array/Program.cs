//Final Project of Multi-Dimensional Array

Console.WriteLine("mult-Dimensional Array in CSharp");
Console.WriteLine("=================================");

string[,,] binaryData = new string[7, 7, 7]
{
    {
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"}
    },
    {
         { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"}
    },
    {
         { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"}
    },
    {
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"}
    },
    {
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"}
    },
    {
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"}
    },
    {
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"},
        {"100","101","110","111","001","101","111" },
        { "100","101","110","111","001","101","111"}
    }
};
Console.WriteLine("First row of Array:");
Console.WriteLine("======================\n");
Console.WriteLine(binaryData[0, 0, 0] + " " + binaryData[0, 0, 1] + " " + binaryData[0, 0, 2] + " " + binaryData[0, 0, 3]);
Console.WriteLine(binaryData[0, 1, 0] + " " + binaryData[0, 1, 1] + " " + binaryData[0, 1, 2] + " " + binaryData[0, 1, 3]);
Console.WriteLine(binaryData[0, 2, 0] + " " + binaryData[0, 2, 1] + " " + binaryData[0, 2, 2] + " " + binaryData[0, 2, 3]);
Console.WriteLine(binaryData[0, 3, 0] + " " + binaryData[0, 3, 1] + " " + binaryData[0, 3, 2] + " " + binaryData[0, 3, 3]);
Console.WriteLine(binaryData[0, 4, 0] + " " + binaryData[0, 4, 1] + " " + binaryData[0, 4, 2] + " " + binaryData[0, 4, 3]);
Console.WriteLine(binaryData[0, 5, 0] + " " + binaryData[0, 5, 1] + " " + binaryData[0, 5, 2] + " " + binaryData[0, 5, 3]);
Console.WriteLine(binaryData[0, 6, 0] + " " + binaryData[0, 6, 1] + " " + binaryData[0, 6, 2] + " " + binaryData[6, 0, 3]);

Console.WriteLine("Second row of Array:");
Console.WriteLine("======================\n");
Console.WriteLine(binaryData[0, 0, 0] + " " + binaryData[0, 0, 1] + " " + binaryData[0, 0, 2] + " " + binaryData[0, 0, 3]);
Console.WriteLine(binaryData[0, 1, 0] + " " + binaryData[0, 1, 1] + " " + binaryData[0, 1, 2] + " " + binaryData[0, 1, 3]);
Console.WriteLine(binaryData[0, 2, 0] + " " + binaryData[0, 2, 1] + " " + binaryData[0, 2, 2] + " " + binaryData[0, 2, 3]);
Console.WriteLine(binaryData[0, 3, 0] + " " + binaryData[0, 3, 1] + " " + binaryData[0, 3, 2] + " " + binaryData[0, 3, 3]);
Console.WriteLine(binaryData[0, 4, 0] + " " + binaryData[0, 4, 1] + " " + binaryData[0, 4, 2] + " " + binaryData[0, 4, 3]);
Console.WriteLine(binaryData[0, 5, 0] + " " + binaryData[0, 5, 1] + " " + binaryData[0, 5, 2] + " " + binaryData[0, 5, 3]);
Console.WriteLine(binaryData[0, 6, 0] + " " + binaryData[0, 6, 1] + " " + binaryData[0, 6, 2] + " " + binaryData[6, 0, 3]);

Console.WriteLine("Third row of Array:");
Console.WriteLine("======================\n");
Console.WriteLine(binaryData[0, 0, 0] + " " + binaryData[0, 0, 1] + " " + binaryData[0, 0, 2] + " " + binaryData[0, 0, 3]);
Console.WriteLine(binaryData[0, 1, 0] + " " + binaryData[0, 1, 1] + " " + binaryData[0, 1, 2] + " " + binaryData[0, 1, 3]);
Console.WriteLine(binaryData[0, 2, 0] + " " + binaryData[0, 2, 1] + " " + binaryData[0, 2, 2] + " " + binaryData[0, 2, 3]);
Console.WriteLine(binaryData[0, 3, 0] + " " + binaryData[0, 3, 1] + " " + binaryData[0, 3, 2] + " " + binaryData[0, 3, 3]);
Console.WriteLine(binaryData[0, 4, 0] + " " + binaryData[0, 4, 1] + " " + binaryData[0, 4, 2] + " " + binaryData[0, 4, 3]);
Console.WriteLine(binaryData[0, 5, 0] + " " + binaryData[0, 5, 1] + " " + binaryData[0, 5, 2] + " " + binaryData[0, 5, 3]);
Console.WriteLine(binaryData[0, 6, 0] + " " + binaryData[0, 6, 1] + " " + binaryData[0, 6, 2] + " " + binaryData[6, 0, 3]);

Console.WriteLine("Four row of Array:");
Console.WriteLine("======================\n");
Console.WriteLine(binaryData[0, 0, 0] + " " + binaryData[0, 0, 1] + " " + binaryData[0, 0, 2] + " " + binaryData[0, 0, 3]);
Console.WriteLine(binaryData[0, 1, 0] + " " + binaryData[0, 1, 1] + " " + binaryData[0, 1, 2] + " " + binaryData[0, 1, 3]);
Console.WriteLine(binaryData[0, 2, 0] + " " + binaryData[0, 2, 1] + " " + binaryData[0, 2, 2] + " " + binaryData[0, 2, 3]);
Console.WriteLine(binaryData[0, 3, 0] + " " + binaryData[0, 3, 1] + " " + binaryData[0, 3, 2] + " " + binaryData[0, 3, 3]);
Console.WriteLine(binaryData[0, 4, 0] + " " + binaryData[0, 4, 1] + " " + binaryData[0, 4, 2] + " " + binaryData[0, 4, 3]);
Console.WriteLine(binaryData[0, 5, 0] + " " + binaryData[0, 5, 1] + " " + binaryData[0, 5, 2] + " " + binaryData[0, 5, 3]);
Console.WriteLine(binaryData[0, 6, 0] + " " + binaryData[0, 6, 1] + " " + binaryData[0, 6, 2] + " " + binaryData[6, 0, 3]);

Console.WriteLine("Fifth row of Array:");
Console.WriteLine("======================\n");
Console.WriteLine(binaryData[0, 0, 0] + " " + binaryData[0, 0, 1] + " " + binaryData[0, 0, 2] + " " + binaryData[0, 0, 3]);
Console.WriteLine(binaryData[0, 1, 0] + " " + binaryData[0, 1, 1] + " " + binaryData[0, 1, 2] + " " + binaryData[0, 1, 3]);
Console.WriteLine(binaryData[0, 2, 0] + " " + binaryData[0, 2, 1] + " " + binaryData[0, 2, 2] + " " + binaryData[0, 2, 3]);
Console.WriteLine(binaryData[0, 3, 0] + " " + binaryData[0, 3, 1] + " " + binaryData[0, 3, 2] + " " + binaryData[0, 3, 3]);
Console.WriteLine(binaryData[0, 4, 0] + " " + binaryData[0, 4, 1] + " " + binaryData[0, 4, 2] + " " + binaryData[0, 4, 3]);
Console.WriteLine(binaryData[0, 5, 0] + " " + binaryData[0, 5, 1] + " " + binaryData[0, 5, 2] + " " + binaryData[0, 5, 3]);
Console.WriteLine(binaryData[0, 6, 0] + " " + binaryData[0, 6, 1] + " " + binaryData[0, 6, 2] + " " + binaryData[6, 0, 3]);

Console.WriteLine("Sixth row of Array:");
Console.WriteLine("======================\n");
Console.WriteLine(binaryData[0, 0, 0] + " " + binaryData[0, 0, 1] + " " + binaryData[0, 0, 2] + " " + binaryData[0, 0, 3]);
Console.WriteLine(binaryData[0, 1, 0] + " " + binaryData[0, 1, 1] + " " + binaryData[0, 1, 2] + " " + binaryData[0, 1, 3]);
Console.WriteLine(binaryData[0, 2, 0] + " " + binaryData[0, 2, 1] + " " + binaryData[0, 2, 2] + " " + binaryData[0, 2, 3]);
Console.WriteLine(binaryData[0, 3, 0] + " " + binaryData[0, 3, 1] + " " + binaryData[0, 3, 2] + " " + binaryData[0, 3, 3]);
Console.WriteLine(binaryData[0, 4, 0] + " " + binaryData[0, 4, 1] + " " + binaryData[0, 4, 2] + " " + binaryData[0, 4, 3]);
Console.WriteLine(binaryData[0, 5, 0] + " " + binaryData[0, 5, 1] + " " + binaryData[0, 5, 2] + " " + binaryData[0, 5, 3]);
Console.WriteLine(binaryData[0, 6, 0] + " " + binaryData[0, 6, 1] + " " + binaryData[0, 6, 2] + " " + binaryData[6, 0, 3]);

Console.WriteLine("Seventh row of Array:");
Console.WriteLine("======================\n");
Console.WriteLine(binaryData[0, 0, 0] + " " + binaryData[0, 0, 1] + " " + binaryData[0, 0, 2] + " " + binaryData[0, 0, 3]);
Console.WriteLine(binaryData[0, 1, 0] + " " + binaryData[0, 1, 1] + " " + binaryData[0, 1, 2] + " " + binaryData[0, 1, 3]);
Console.WriteLine(binaryData[0, 2, 0] + " " + binaryData[0, 2, 1] + " " + binaryData[0, 2, 2] + " " + binaryData[0, 2, 3]);
Console.WriteLine(binaryData[0, 3, 0] + " " + binaryData[0, 3, 1] + " " + binaryData[0, 3, 2] + " " + binaryData[0, 3, 3]);
Console.WriteLine(binaryData[0, 4, 0] + " " + binaryData[0, 4, 1] + " " + binaryData[0, 4, 2] + " " + binaryData[0, 4, 3]);
Console.WriteLine(binaryData[0, 5, 0] + " " + binaryData[0, 5, 1] + " " + binaryData[0, 5, 2] + " " + binaryData[0, 5, 3]);
Console.WriteLine(binaryData[0, 6, 0] + " " + binaryData[0, 6, 1] + " " + binaryData[0, 6, 2] + " " + binaryData[6, 0, 3]);

