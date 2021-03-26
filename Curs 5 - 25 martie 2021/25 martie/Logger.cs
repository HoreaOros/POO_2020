using System.Collections.Generic;

namespace _25_martie
{
    internal class Logger
    {
        private static List<string> data = new List<string>();
        public static void log(string message)
        {
            data.Add(message);
        }
        public static List<string> Data
        { 
            get
            {
                return data;
            }
        }
    }
}