using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Models
{
    public class EventCategory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name of event Category is required")]
        public string Name { get; set; }

        public EventCategory()
        {

        }
        public EventCategory(string name)
        {
            Name = Name;
        }
    }
}
