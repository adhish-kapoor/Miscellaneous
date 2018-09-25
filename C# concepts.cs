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

C# Serialization & Deserialization
//Serialization is a concept in which C# class objects are written or serialized to files.
//example C# class Tutorial having 2 properties ID and Tutorial name
//Serializing can be used to directly write the data properties of the Tutorial class to a file.
//Deserialization is used to read the data from the file and construct the Tutorial object again.
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
  [Serializable]
  class Tutorial
  {
  public int ID;
  public String Name;
   static void Main(string[] args)
   {
    Tutorial obj = new Tutorial();
    obj.ID = 1;
    obj.Name = ".Net";
 
    //create the file stream
    IFormatter formatter = new BinaryFormatter();
    Stream stream = new FileStream(@"E:\ExampleNew.txt",FileMode.Create,FileAccess.Write);

    //serialize the object
    formatter.Serialize(stream, obj);
    stream.Close();

    //create the file stream
    stream = new FileStream(@"E:\ExampleNew.txt",FileMode.Open,FileAccess.Read);
    
    //deserialize the object
    Tutorial objnew = (Tutorial)formatter.Deserialize(stream);

    //write data to the console
    Console.WriteLine(objnew.ID);
    Console.WriteLine(objnew.Name);

    Console.ReadKey();
  }
 }
}
