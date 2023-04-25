using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Task.Models
{
    public class User
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private static int age { get; set; }
        public void GetFullName()
        {
            Console.WriteLine(Name +" "+Surname);
        }
    }

}
