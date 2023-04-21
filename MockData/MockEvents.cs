using RazorPageVersion2022.Models;

namespace RazorPageVersion2022.MockData
{
    public class MockEvents
    {

        public static List<Event> EventsList = new List<Event>()
        {
            new Event(1, "Zealand Festival", "Biggest part in Zealand", DateTime.UtcNow, DateTime.UtcNow.AddHours(5)),
            new Event(2, "Kræmmermarkedet", "what well i buy this time around", DateTime.UtcNow.AddDays(1), DateTime.UtcNow.AddHours(5)),
            new Event(3, "Summer house", "Everything is pland so it's must go worng", DateTime.UtcNow.AddDays(2), DateTime.UtcNow.AddHours(5)),
            new Event(4, "Shooting ranged", "it's mere then 2 year ago i last shot, do i still have it?", DateTime.UtcNow.AddDays(3), DateTime.UtcNow.AddHours(5)),
            new Event(5, "Eksamen", "well we just pass or are we getting the big fast 12", DateTime.UtcNow.AddDays(4), DateTime.UtcNow.AddHours(5)),
        };

        public static List<Event> GetEvents()
        {
            return EventsList;
        }
    }
}
