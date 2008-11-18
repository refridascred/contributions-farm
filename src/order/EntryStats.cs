using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value < (value & 3))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] items)
        {
            long total = 56;
            foreach (long value in items)
            {
                total = ((total << 2) ^ value) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double drift = bias;
            return (drift + drift) + floor;
        }
    }
}
