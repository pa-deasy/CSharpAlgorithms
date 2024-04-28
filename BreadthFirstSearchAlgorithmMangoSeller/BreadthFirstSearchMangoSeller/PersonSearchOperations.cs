using System.Collections.Generic;
using System.Linq;

namespace BreadthFirstSearchMangoSeller
{
    public static class PersonSearchOperations
    {
        public static string ClosestMangoSeller(this Node node)
        {
            var contactsQueue = new Queue<Node>(node.Contacts);
            var checkedContacts = new List<Node>();
        
            while (contactsQueue.Any())
            {
                var contact = contactsQueue.Dequeue();

                if (checkedContacts.Contains(contact))
                    continue;

                if (contact.Value.MangoSeller)
                    return contact.Value.Name;

                contact.Contacts.ForEach(c => contactsQueue.Enqueue(c));
                checkedContacts.Add(contact);
            }
        
            return string.Empty;
        }
    }
}
