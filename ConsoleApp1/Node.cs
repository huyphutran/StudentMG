using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedListStudentManagment
{

    public class Node
    {
        public Student student = null;
        public Node(Student student)
        {
            this.student = student;
            next = null;
        }
        // value of this Node

        // link to next Node in list
        public Node next = null;

        private Node root = null;

        public Node First { get { return root; } }

        public Node Last
        {
            get
            {
                Node curr = root;
                if (curr == null)
                    return null;
                while (curr.next != null)
                    curr = curr.next;
                return curr;
            }
        }

    
    }
}
