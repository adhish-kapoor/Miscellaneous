Char.IsNumber(Char) Method //method to check whether the specified Unicode character matches number or not

using System;
 
class GFG {
 
    // Main Method
    static public void Main()
    {
 
        // Declaration of data type
        bool result;
 
        // checking if 5 is a
        // number or not
        char ch1 = '5';
        result = Char.IsNumber(ch1);
        Console.WriteLine(result);    //True
 
        // checking if 'c' is a
        // number or not
        char ch2 = 'c';
        result = Char.IsNumber(ch2);
        Console.WriteLine(result);    //False
    }
}
