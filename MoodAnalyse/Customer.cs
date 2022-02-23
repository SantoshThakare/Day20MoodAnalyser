using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyse
{
        public class Customer
        {
            public int Id { get; set; }

            public string Name { get; set; }

            
            public Customer(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }
            public Customer()
            {
                this.Id = 15;
                this.Name = string.Empty;  
            }
            public void PrintId()
            {
                this.Id = 35;
                Console.WriteLine("Id is : {0}", this.Id);
            }
            public void PrintName()
            {
                this.Name = "Santosh";
                Console.WriteLine("Name is : {0}", this.Name);
            }
        }
}
