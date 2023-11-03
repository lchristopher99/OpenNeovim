using System.Diagnostics;

public class Program 
{
    public static void Main(string[] args)
    {
        if (args.Length == 0) return;

        var p = new ProcessStartInfo()
        {
            UseShellExecute = true,
            CreateNoWindow = true,
            FileName = "pwsh",
            Arguments = $"-noexit -c nv {args[0]}"
        };

        try { Process.Start(p); }
        catch {}
    }
}
