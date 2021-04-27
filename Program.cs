using System;

namespace DoubleLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkList mylist = new DoublyLinkList();
            mylist.Append("Intouch");
            mylist.Append("Prem");
            mylist.Append("Toy");
            mylist.Append("David");
            mylist.Append("Ankit");
          
          
          
            mylist.delete("Toy");
            mylist.delete("Ankit");
            mylist.delete("Intouch");

            mylist.printList();
            mylist.ReversePrintList();
           

        }
    }
}
