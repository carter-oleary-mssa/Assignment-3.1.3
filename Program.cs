string[] s = { "This is a test string", "Some   weird spacingin   this       one" };

foreach (string test in s)
{
    Console.WriteLine($"The string \"{test}\" has {GetNumberOfSpaces(test)} spaces.");
}

int GetNumberOfSpaces(string s)
{
    int numSpaces = 0;
    foreach(char c in s)
    {
        if (c == ' ') { numSpaces++; }
    }
    return numSpaces;
}

