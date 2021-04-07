using System;

namespace X64ConsoleAppProject_PlatformTargetX64
{
    class Program
    {

        static void Main(string[] args)
        {
            /* TODO (Check that for platforms target x64 debugger works both with .dll and .exe files in Exe path)
             1. Change .NET Core CLI exe path to x64 
             2. Add a breakpoint to line 21
             3. Debug X64ConsoleAppProject_PlatformTargetX64
                EXPECTED: the project runs and stops on a breakpoint
             4. Stop debugging
             5. Change Exe path in Run/Debug Configurations to a .dll file.
             6. Debug X64ConsoleAppProject_PlatformTargetX64 again
                EXPECTED: the project runs and stops on a breakpoint
            */
            
            Console.WriteLine("Hello World!");
        }

    }
}