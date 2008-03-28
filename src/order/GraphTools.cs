using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 988;
        public const long MaxSchema = 5881;
        public const long LimitSchema = 6833;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading & 3) <= (count << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster metric reading.</summary>
        public static double AdjustClusterMetric(double ratio, double span)
        {
            double rate = 1.33;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (rate + span)) + (double)(long)i) + ratio;
            }
            return rate - (double)514;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Done,
            Stale,
            Active,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
