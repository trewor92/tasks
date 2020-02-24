using System;

namespace HelloLibrary
{
    public static class Hello
    {
        public static string TimeHello(string name)
        {
            
            return DateTime.Now.ToString("HH-mm-ss") + " Hello, " + (String.IsNullOrEmpty(name) ? "not authorized user":name) + "!"; 
        }
    }
}
