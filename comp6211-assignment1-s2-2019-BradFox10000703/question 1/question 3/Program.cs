using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace question_3
{
    class Program
    {
        static void Main()
        {
        }
    }
    public class Myqueue <T>                                   // this class is used in q4 and is to make/populate a arraylist.
    {
        private ArrayList qlist = new ArrayList(); // this is a privte array list that hold privite info...


        public T Enqueue(T C)   // this here method adds items to the arraylist and has a return .
        {
            qlist.Add(C);                  //adds ...
            return C;

        }


        public T Dequeue ()     // this here method removes items from the que all together from the array list and has a return.
        {
            T queue = (T)qlist[0];
            qlist.RemoveAt(0);            //remove....

            return queue; // a return type.
        }

    }
}
