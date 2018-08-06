 public  class Linkedlist
    {
        public Node head;
        public class Node
        {
           public Node next;
           public  int data;         
          public   Node(int a)
            {
                data = a;
                next = null;
            }
         
        }

        public void Addnext(int element)
        {
            if (head == null)
            {
                head = new Node(element);
            }
            else
            {
                Node addnode = new Node(element);
                head.next = addnode;
            }
        }

        public void Addlast(int element)
        {
            Node current = head;
            Node lastnode = new Node(element);
            while (current.next!=null)
            {
                current = current.next;
            }
            current.next = lastnode;
        }


        public void Bhead(int element)
        {
            Node current = head;
            Node Precurrent = new Node(element);
            Precurrent.next = head;
            head = Precurrent;
        }

        public void Deletehead()
        {
            Node current = head;
            head = current.next;
        }

        public void Deletedata(int data)
        {
            Node current = head;
            if (head==null)
            {
                return;
            }
            if (head.data==data)
            {
                head = head.next;
                return;
            }    
            while (current.next!=null)
            {
                if (current.next.data==data)
                {

                    current.next = current.next.next;                  
                }
                current = current.next;
                return;                        
            }
        }
        public void printall()
        {
            Node current= head;
            while (current!=null)
            {
                Console.WriteLine(current.data);
                current = current.next;                            
            }
        }
    }
