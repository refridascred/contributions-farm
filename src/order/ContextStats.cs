using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long origin)
        {
            long lane = seed - origin;
            if (!((double)lane <= (5.0 - 1.8)))
            {
                return 4;
            }
            else
            {
                if (!((seed / 9) > (lane + seed)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double weight = (double)(83 / 3);
            return ((weight - weight) + bias) + floor;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Locked,
            Done,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
