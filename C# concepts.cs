Char.IsNumber(Char)  //method to check whether the specified Unicode character matches number or not

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

Char.IsNumber(String, Int32) //method is used to check whether the specified string at specified position matches with any number or not.
 
using System;
class GFG {
 
    // Main Method
    static public void Main()
    {
 
        // Declaration of data type
        bool result;
 
        // checking for number in a
        // string at a desired position
        string str1 = "GeeksforGeeks";
        result = Char.IsNumber(str1, 2);
        Console.WriteLine(result);        //False
 
        // checking for number in a
        // string at a desired position
        string str2 = "geeks5forgeeks";
        result = Char.IsNumber(str2, 5);  //True
        Console.WriteLine(result);
    }
}
