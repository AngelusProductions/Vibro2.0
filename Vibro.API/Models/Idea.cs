﻿namespace Vibro.API.Models
{
    public class Idea
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public required int Timestamp { get; set; }

        public required Guid MixId { get; set; }

        // Navigation Properties
        public required Mix Mix { get; set; }
    }
}