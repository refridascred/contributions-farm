using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Synced,
            New,
            Draft,
            Active,
        }
    }
}
