using System.IO;
using System.Text;
namespace Prn.FileStreamDemo;
public class Program
{
    public static void Main()
    {
        //1. Khoi tao contents
        string msg = "ABCDEF123";
        //2. Convert ,sg => byte array - 1D
        byte[] msgBytes = Encoding.UTF8.GetBytes(msg);
        //3. Dung FileStream de mo 1 file
        try
        {
            FileStream fileStream = File.Open(@"D:\ky5\demo\data.dat", FileMode.Create);
            fileStream.Write(msgBytes, 0, msgBytes.Length);
            fileStream.Position = 0;
            fileStream.Close();
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        //4  Save msgBytes => file data.dat
        Console.WriteLine("Finished....");
        Console.ReadLine();
    }
}