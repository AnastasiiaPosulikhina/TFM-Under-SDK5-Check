using System;

namespace ConsoleAppProject_PlatformTargetX86
{
    class Program
    {

        static void Main(string[] args)
        {
            /* TODO (Check that for platforms target x86 debugger works both with .dll and .exe files in Exe path)
             1. Add a breakpoint to line 20
             2. Debug ConsoleAppProject_PlatformTargetX86
                EXPECTED: the project runs and stops on a breakpoint
             3. Stop debugging
             4. Change Exe path in Run/Debug Configurations to a .dll file.
             5. Debug ConsoleAppProject_PlatformTargetX86 again
                EXPECTED: the project runs and stops on a breakpoint
            */
            
            Console.WriteLine("Hello World!");
        }

    }
}