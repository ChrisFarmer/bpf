using System;

namespace FileData.UI
{
    public static class UserInterface
    {
        public static void Output(string message)
        {
            Console.WriteLine(message);
            Console.Read();
        }
    }
}
