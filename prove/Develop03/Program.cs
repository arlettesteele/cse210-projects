//I added a reset option to reset the scripture//

using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 9, 6);

        string scriptureText = ("But the Lord knoweth all things from the beginning; wherefore, he prepareth a way to accomplish all his works among the children of men; for behold, he hath all power unto the fulfilling of all his words. And thus it is. Amen.");
        
        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\n Press enter to continue, type 'reset; to reset the scripture or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input.ToLower() == "reset")
            {
                scripture.ResetScripture();
            }

            scripture.HideRandomWords(3);
        }
    }
}