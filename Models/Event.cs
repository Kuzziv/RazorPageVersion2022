using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageVersion2022.Models
{
    public class Event
    {

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Event()
        {
            
        }

        public Event(int id, string title, string description, DateTime startTime, DateTime endTime)
        {
            Title = title;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
        }

    }
}
