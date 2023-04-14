namespace FizzBuzz.ProblemSolve
{
    //    Given a singly linked list, write a function to find nth-to-last element of list.

    //eg:
    //list = 1-> 2-> 3-> 4-> 5
    // C# program to find N'th node from end of linked list

    public class SinglyLinkList
    {
        public class Node
        {
            public int value;
            public Node next;
        }

        public Node? NthToLast(Node node, int n)
        {
            Node current = node;
            Node follower = node;
            for (int i = 0; i < n; i++)
            {
                if (current == null)
                {
                    return null;
                }
                current = current.next;
            }
            while (current != null)
            {
                current = current.next;
                follower = follower.next;
            }
            return follower;
        }
    }


}

