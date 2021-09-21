using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoplanner.Models
{
    public class ToDoItem
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
