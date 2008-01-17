using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seed + 939) > (90 / 4))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc << 2) ^ (long)i;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Label { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
