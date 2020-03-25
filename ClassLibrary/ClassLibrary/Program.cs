using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestPerson();
            Console.ReadKey();
        }
        static void TestPerson()
        {
            using (ModelClassLibraryContainer context = new ModelClassLibraryContainer())
            {
                Comment p = new Comment()
                {
                    Text = "Experimental Text",
                    PostPostId = "1322"
                };
                context.Comments.Add(p);
                context.SaveChanges();
                var items = context.Comments;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Text, x.PostPostId);
            }
        }
    }

}
