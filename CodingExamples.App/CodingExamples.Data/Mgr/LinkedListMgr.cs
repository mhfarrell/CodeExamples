using System;
using System.Collections.Generic;
using System.Text;
using CodingExamples.Data.Class;

namespace CodingExamples.Data.Mgr
{
    public class LinkedListMgr
    {
        private Node head;

        public void printList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public List<string> ToList()
        {
            List<string> list = new List<string>();
            Node current = head;
            while (current != null)
            {
                list.Add(current.data.ToString());
                current = current.next;
            }
            return list;
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        public void DeleteLast()
        {

        }

        public void DeleteFirst()
        {

        }

        public void DeleteAny(Object data)
        {

        }
    }
}
