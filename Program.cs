using System.Diagnostics;

public class Program 
{
    public static void Main(string[] args)
    {
        try 
        { 
            Process.Start(new ProcessStartInfo()
            {
                UseShellExecute = true,
                CreateNoWindow = true,
                FileName = "pwsh",
                Arguments = $"-noexit -c nv {args[0]}"
            }); 
        }
        catch {}
    }
}
