namespace MyStringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            string s = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(s[11]);
            
            //Q2                 
            if (s.Contains("is") == true)
            {
                Console.WriteLine("Word found!");
            }
            else
            {
                Console.WriteLine("Word not found!");
            }

            //Q3
            string s1 = "and killed it";
            string s2 = String.Concat(s, " " + s1); //s2+s3
            Console.WriteLine(s2);

            //Q4
            Boolean x = s.EndsWith("dogs");
            Console.WriteLine(x);          

            //Q5
            string s3 = "The quick brown Fox jumps over the lazy Dog";
            string s4 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            Console.WriteLine(s.Equals(s3));
            Console.WriteLine(s.Equals(s4));

            //Q6
            Console.WriteLine("Length {0}", s.Length);

            //Q7
            string s5 = "The quick brown Fox jumps over the lazy Dog";
            Console.WriteLine(s.Equals(s5));

            //Q8
            s = s.Replace("The", "A");
            Console.WriteLine(s);

            //Q10
            string s6 = "fox";
            string s7 = "dog";

            if (String.Compare(s, s6) != 0)
            {
                Console.WriteLine(s6);
            }
            if (String.Compare(s, s7) != 0)
            {
                Console.WriteLine(s7);
            }

            //Q11
            Console.WriteLine(s.ToLower());

            //Q12
            Console.WriteLine(s.ToUpper());

            //Q13
            Console.WriteLine(s.IndexOf('a'));

            //Q14
            Console.WriteLine(s.LastIndexOf('e'));

            //Q15
            string Path = Console.ReadLine();
            string add = @"WebApps\MyApps\Images";
            Console.WriteLine($"Tomcat Path: {Path + add}");

            //Q16
            string st = @"I WANDER'D lonely as a cloud
That floats on high o'er vales and hills, 
When all at once I saw a crowd,
A host, of golden daffodils;Beside the lake, beneath the trees,
Fluttering and dancing in the breeze";
            Console.WriteLine(st);



        }
    }
}