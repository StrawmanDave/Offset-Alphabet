// David 10/26/24 Offset Alphabet

Console.Clear();
int holder;
int i = 0;
int Offset = ReadNumber();
string alphabet = "abcdefghijklmnopqrstuvwxyz";

OffSetString(Offset,alphabet);

// Method for Offsetting the string or in this case the alphabet
void OffSetString(int AmountToOffset, string WhatToOffset)
{
    while(AmountToOffset>i)
    {
        WhatToOffset = WhatToOffset.Substring(1) + WhatToOffset[0];
        i++;
    }
    Console.WriteLine($"Here is your string offset by {AmountToOffset}");
    Console.WriteLine(WhatToOffset);
}

// Method for getting a number
int ReadNumber()
{
    while(true)
    {
        
        Console.Write("Please Enter a number ");
        string num = Console.ReadLine();

        bool isNum = int.TryParse(num, out holder);
        if(isNum == false) // Checks if the user put in a number
        {
            Console.WriteLine("That was not a number try again");
        }else
        {
            int number = Convert.ToInt32(num);
            return number;
        }
    }
}