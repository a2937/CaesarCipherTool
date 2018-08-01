 using System;

namespace CaesarCypherApplierCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = CypherTool.DecodeCypher(keyCodes:"53,53,58,59,55,57,84,77,52,77,", rawAscii:true,shift:15,separater:',');
            Console.Out.WriteLine(text);
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}
