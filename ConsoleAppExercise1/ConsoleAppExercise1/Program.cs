using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "David ";
            string age = "33 ";
            string state = "WA";

            Console.WriteLine(name.ToUpper() + age + state.ToLower());

            StringBuilder sb = new StringBuilder();

            sb.Append("What I thought I'd do was pretend to be one of those deaf mutes. \n");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("That way I wouldn't have to have any useless conversations with anybody. \n");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("If anybody wanted to tell me something, they'd have to write it on a piece of paper and shove it over to me. \n");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("They'd get bored doing that after a while, and then I'd be through with having conversations for the rest of my life. \n");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("Everybody'd think I was just a poor deaf-mute and they'd leave me alone . . . \n");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("I'd cook all my own food, and later on, \n I'd meet this beautiful girl that was also a deaf-mute and we'd get married. \n");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("She'd come and live in my cabin with me, and if she wanted to say anything to me, \n she'd have to write it on a piece of paper, like everybody else.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
