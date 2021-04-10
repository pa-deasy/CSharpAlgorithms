using System.Collections.Generic;

namespace BreadthFirstSearchMangoSeller
{
    public class Node
    {
        public Person Value { get; set; }
        public List<Node> Contacts { get; set; }
    }
}
