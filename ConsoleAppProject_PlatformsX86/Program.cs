using System;

namespace ConsoleAppProject_PlatformsX86
{
    class Program
    {
        /* Preconditions:
         1. Go to `Settings | Build, Execution, Deployment | Toolset and Build` and make sure .NET Core CLI exe path is
         valid for x86 target platform
         2. Make sure sdk5 is chosen in `Use MSBuild version`
         3. Go to Run/Debug Configurations and make sure that each .NET project config has an .exe file in its Exe path
         4. For macOS: change <TargetFramework>net5.0-windows</TargetFramework> to 
         <TargetFramework>net5.0-macos</TargetFramework> in each .csproj file
         */

        static void Main(string[] args)
        {
            /* TODO (Check that for x86 platforms debugger works both with .dll and .exe files in Exe path)
             1. Add a breakpoint to line 28
             2. Debug ConsoleAppProject_PlatformsX86
                EXPECTED: the project runs and stops on a breakpoint
             3. Stop debugging
             4. Change Exe path in Run/Debug Configurations to a .dll file.
             5. Debug ConsoleAppProject_PlatformsX86 again
                EXPECTED: the project runs and stops on a breakpoint
            */

            Console.WriteLine("Hello World!");
        }

    }
}