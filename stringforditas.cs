using System;

namespace string_fordítás
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ide jöhet a string: ");
            string bekert = Console.ReadLine();
            Console.WriteLine();
            bool i = true;
            int k = bekert.Length;
            k--;
            //K változó = a bekért string hossza

            string forditva="";
            // a fordított stringet fogom ebbe tárolni

            while (i==true)
            {
                forditva += bekert[k];
                k--;
                if (k < 0)
                    i = false;
            }
            Console.WriteLine("A mondat amit beküldtél:"+bekert+"\n\n");
            Console.WriteLine("Fordítva: "+forditva);
            Console.ReadLine();


        }
    }
}
