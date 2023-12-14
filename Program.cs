using System;
using System.IO;
using System.Collections;

public class FileReader
{
    public string[] ReadFile(String path)
    {
        string[] fileInput = new string[0];
        try
        {
            
            // Open the text file using a stream reader.
            using (var sr = new StreamReader(path))
            {
                // Read the stream as a string.
                String full_Text = "";
                full_Text =sr.ReadToEnd();
                //Split String
                fileInput = full_Text.Split("\r\n");
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        return fileInput;
    }
}

class Program
{
    public static void Main()
    {

    }
}