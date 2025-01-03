using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cshaarp_Learning;

namespace Cshaarp_Learning
{
    internal class Encapsulation
    {
        private string _name;
        private int _id;

        //Properties

        public string Name { get => _name; set { if(string.IsNullOrEmpty(value))
                                                    {
                                                    Console.WriteLine("Name: Name should not empty");
                                                     }//if end
                                                    else
                                                    {
                                                        _name = value;
                                                         Console.WriteLine($"Name :{Name}");
                }                                                      
                                                 }//name set end        
                            }//property end
        public int Id { get => _id; set
                                    {
                                        if (value >0 )
                                        {
                                            _id = value;
                                              Console.WriteLine($"Id:{Id}");
                }//if end
                                        else
                                        {
                                            Console.WriteLine("ID:Please enter greater than 0");
                                        }
                                    }//id set end
                        }//Propertie end

        public Encapsulation(String name, int id)
        {
            Name = name;
            Id = id;
           // Console.WriteLine($"Name :{Name}, Id:{Id}");
        }


        //public string Name { get => _name; set => _name = value; }

    }
}
//main method
// Encapsulation e= new Encapsulation("Pola", 100);
// Encapsulation e1 = new Encapsulation("", 100);
//Encapsulation e2 = new Encapsulation("", 0);