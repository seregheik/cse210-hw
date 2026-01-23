using System.IO;
using System;
public class LastSave
{
    public bool _askLastSave = true;
    public void SaveLastSave (string filename)
    {
        using (StreamWriter outputFile = new StreamWriter("lastMemory.txt"))
        {
             outputFile.Write(filename);
            
        }
    }
    public string LoadLastSavedFile ()
    {
        try
        {
           string lastSave = System.IO.File.ReadAllText("lastMemory.txt"); 
           return lastSave;
        }
        catch (System.Exception)
        {
            return "No last save";
        }
    
    
    }
}