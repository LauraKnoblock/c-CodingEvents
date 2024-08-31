using CodingEvents.Models;
using System;
namespace CodingEvents.Data
{
    public class EventData
    {
        static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        // AD A NEW VEVENT TO MY FICTIONARU
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        // remove an event from the dictionary
        public static void Remove(int id)
        {
            Events.Remove(id);
        }

        // fetch a specific event
        public static Event GetById(int id)
        {
            return Events[id];
        }
    }
}
