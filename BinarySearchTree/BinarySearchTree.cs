using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private Node root;
        
        public BinarySearchTree()
        {
            root = null;
        }

        

        public void Add()
        {
            root = new Node(250);
            root.leftChild = new Node(175);
            root.rightChild = new Node(280);
            root.leftChild.leftChild = new Node(150);
            root.leftChild.rightChild = new Node(190);
            root.rightChild.leftChild = new Node(240);
            root.rightChild.rightChild = new Node(285);
            root.leftChild.leftChild.leftChild = new Node(120);
            root.leftChild.leftChild.rightChild = new Node(160);
            root.leftChild.rightChild.leftChild = new Node(185);
            root.leftChild.rightChild.rightChild = new Node(200);
            root.rightChild.leftChild.leftChild = new Node(230);
            root.rightChild.leftChild.rightChild = new Node(245);
            root.rightChild.rightChild.leftChild = new Node(275);
            root.rightChild.rightChild.rightChild = new Node(300);

            
            

            //Start at the root. Check if the root is null. Assign the root a value. //Then traverse if the root has a value. 
        }

        public void Search()
        {

        }
    }
}
