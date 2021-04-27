using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkList
{
    class DoublyLinkList
    {
        node head = null;
        node tail = null;
        public DoublyLinkList()
        {

        }
        public void Append(string name)
        {
            if(head == null)
            {
                head = new node(null,name, null);
                tail = head;
            }
            else
            {
                node newNode = new node(null, name, null);
                tail.next = newNode;
                newNode.previous = tail;
                tail = newNode;
            }
        }
        public void printList()
        {
            node current = head;
            while (current != null)
            {
                Console.WriteLine(current.name);
                current = current.next;
            }
        }
        public void ReversePrintList()
        {
            node current = tail;
            while (current != null)
            {
                Console.WriteLine(current.name);
                current = current.previous;
            }
        }
        public void prepend(string name)
        {
            if (head == null)
            {
                head = new node(null, name, null);
                tail = head;
            }
            else
            {
                node newNode = new node(null, name, null);
                head.previous = newNode;
                newNode.next = head;
                head = newNode;
            }
        }
        public void delete(string name)
        {
            node current = head;
            while (current.next != null)
            {
                if (current.name == name)
                {
                    head = current.next;
                    current.next.previous = null;
                    return;
                }
                if (current.next.name == name && current.next.next != null)
                {
                    current.next.next.previous = current;
                    current.next = current.next.next;                
                    return;
                }
                else if (current.next.name == name && current.next.next == null)
                {
                    current.next = null;
                    tail = current;
                    return;
                }
                current = current.next;
            }
        }
    }

}
