﻿using System;
using System.Threading.Tasks.Dataflow;
namespace CodingEvents.Models
{
    public class Event
    {
        public string? Name { get; set; }
        
        public string? Description { get; set; }

        public string? ContactEmail { get; set; }
        
        public int Id {  get; set; }
        static private int nextId = 1;

        public EventType Type { get; set; }

        public Event()
        {
            Id = nextId;
            nextId++;
        }
        public Event(string name, string description)
        {
            Name = name;
            Description = description;
            Id = nextId;
            nextId++;
        }

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Event @event && Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
