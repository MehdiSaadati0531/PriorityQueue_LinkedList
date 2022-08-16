using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue_LinkedList
{
    class Node
    {
        public int Value;
        public Node Next;
        public Node Prev;
        public int Priority;
    }

    public class ModelsAndImplement
    {
        Node head;

        private bool IsNull()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeQueue()
        {
            if (IsNull())
            {
                Console.WriteLine("Queue Is Empty !!");
            }
            else
            {
                if (head.Next == null)
                {
                    head = null;
                    return;
                }
                else
                {
                    Node popedItemNode = head;
                    Node temp = head.Next;
                    while (temp != null)
                    {
                        if (popedItemNode.Priority >= temp.Priority)
                        {
                            popedItemNode = temp;
                        }
                        temp = temp.Next;
                    }
                    if (popedItemNode.Next == null)
                    {
                        popedItemNode.Prev.Next = null;
                    }
                    else if (popedItemNode.Prev == null) 
                    {
                        head = head.Next;
                    }
                    else
                    {
                        popedItemNode.Prev.Next = popedItemNode.Next;
                        popedItemNode.Next.Prev = popedItemNode.Prev;
                    }
                }
            }
        }

        public void Enqueue(int val, int priority)
        {
            if (IsNull())
            {
                Node newnode = new Node();
                newnode.Value = val;
                newnode.Priority = priority;
                newnode.Prev = null;
                newnode.Next = null;
                head = newnode;
            }
            else
            {
                Node findLastItem = head;
                Node newnode = new Node();
                while (findLastItem.Next != null)
                {
                    findLastItem = findLastItem.Next;
                }
                newnode.Value = val;
                newnode.Priority = priority;
                newnode.Next = null;
                newnode.Prev = findLastItem;
                findLastItem.Next = newnode;
            }
        }

        public void Print()
        {
            if (IsNull())
            {
                Console.WriteLine("Empty !!!");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine($"value {temp.Value} / priority {temp.Priority}");
                    temp = temp.Next;
                }
            }
        }
    }
}
