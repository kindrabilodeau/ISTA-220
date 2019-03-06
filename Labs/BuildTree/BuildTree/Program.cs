using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree; 

namespace BuildTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<char> charTree = null;
            InsertIntoTree<char>(ref charTree, 'M', 'X', 'A', 'M', 'Z', 'Z', 'N');
            string sortedData = charTree.WalkTree();
            Console.WriteLine($"Sorted data is:{sortedData}");
        }

        static void InsertIntoTree<TItem>(ref Tree<TItem> tree, params TItem[] data)
            where TItem : IComparable<TItem>
        {
            foreach (TItem datum in data)
            {
                if (tree == null)
                    tree = new Tree<TItem>(datum);
                else
                    tree.Insert(datum);
            }
        }
    }


    class Book : IComparable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ID { get; set; }
        public DateTime PubDate { get; set; }

        public int CompareTo(Book obj)
        {
            if (this.ID > obj.ID)
                return 1;
            else if (this.ID < obj.ID)
                return -1;
            else
                return 0; 
        }
    }
}
