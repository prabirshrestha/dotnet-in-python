using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;
using Roslyn.Compilers;
using Roslyn.Scripting;
using Roslyn.Scripting.CSharp;

namespace RoslynInPython
{
    public class HelloWorld
    {
        [DllExport("hour", CallingConvention.Cdecl)]
        static long hour()
        {
            return DateTime.Now.Hour;
        }

        [DllExport("minute", CallingConvention.Cdecl)]
        static long minute()
        {
            return DateTime.Now.Minute;
        }

        [DllExport("hello", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.BStr)]
        static string Hello()
        {
            return "Hello from C#";
        }


        [DllExport("eval", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.BStr)]
        static string eval([MarshalAs(UnmanagedType.LPWStr)] string code)
        {
            return code;
        }


    }
}
