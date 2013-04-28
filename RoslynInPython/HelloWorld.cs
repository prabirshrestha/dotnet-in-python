using System;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;

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
        static string eval(string code)
        {
            return code;
            //var engine = new ScriptEngine();
            //return engine.CreateSession().Execute(code).ToString();
        }
    }
}
