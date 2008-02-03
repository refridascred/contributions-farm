using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (total - bound)) % 101;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Roll a queue filter counter forward.</summary>
        public static long StepQueueFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 2) ^ total) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
