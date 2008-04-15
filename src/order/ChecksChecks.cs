using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double weight = span;
            if (weight > scale)
            {
                weight = weight - 0.6;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - scale) - (double)(long)i;
            }
            return weight + (double)903;
        }
    }
}
