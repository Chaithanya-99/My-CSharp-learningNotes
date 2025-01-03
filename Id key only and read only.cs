using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshaarp_Learning
{
    internal class Id_key_only_and_read_only
    {
        //static field to hold the next valuu of id available		
        private static int nextid = 0;
        //read only inatance Fiels which can be intialized only once from the constructor 		
        private readonly int _stuid;
        //Properties		
        public string Name { get; set; }

        //public int Id { get; set; }		

        public int Classs { get; set; }


        //custom constructure		
        //optional parameter at constructure level		
        public Id_key_only_and_read_only(string name, int id = 100, int classs = 10)
        {
            //sive _id is readonly we cannot override this and while insertind each will have the unique id value		
            _stuid = nextid++;//this will assign the increment value to id		
            Name = name;
            // Id = id;		
            Classs = classs;
            //  Console.WriteLine($"Name is :{Name}, Id is: {Id},class is:{Classs}");		
        }
        //Below is a method inside a Class		
        //below we user optional/default parameter, if you wont give input for that by default it will be 10		
        //public void studentdet(string name, int id, int classs = 10)
        //{
        //    Name = name;
        //    // Id = id;		
        //    Classs = classs;

        //    Console.WriteLine($"Hi this is{Name} , my id is {_stuid} and I'M from {Classs}");
        //}
       // below method denni use chese output print chestamu
        public void getdetails()
        {
            Console.WriteLine($"Name is :{Name}, Id is: {_stuid},class is:{Classs}");
        }
        //Id_key_only_and_read_only m = new Id_key_only_and_read_only("pola");
        //Id_key_only_and_read_only m1 = new Id_key_only_and_read_only("Chaithanya");

        //m.getdetails();
        //m1.getdetails();

    }
}
//summary: nextid varible ke initial ga 0 declare chesam
//_stuid ke datatype ga readonly vadam ante onlly okasari daniki value assign cheyagalam
//stuid ke nextid ne assign chedam, so manam em value ivvakunna inde automatic ga increment avvuthu value ne assign chestundi like identiy in sql 

