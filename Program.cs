// David 10/26/24 Offset Alphabet

Console.Clear();
int i = 0;
int Offset = ReadNumber();
string alphabet = "abcdefghijklmnopqrstuvwxyz";

OffSetString(Offset,alphabet);

void OffSetString(int AmountToOffset, string WhatToOffset)
{
    while(amountOffset>i)
    {
        WhatToOffset = WhatToOffset.Substring(1) + WhatToOffset[0];
        i++;
    }
    Console.WriteLine(WhatToOffset);
}
int ReadNumber()
{
    while(true)
    {
        Console.Write("Please Enter a number ");
        string num = Console.ReadLine();
        if(!"123456789".Contains(num)) // Checks if the user put in a number
        {
            Console.WriteLine("That was not a number try again");
        }else
        {
            int number = Convert.ToInt32(num);
            return number;
        }
    }
}