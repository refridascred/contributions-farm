using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            New,
            Locked,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels, long offset)
        {
            long sum = -2;
            foreach (long reading in levels)
            {
                sum = (((sum * 3) + offset) % 97) ^ reading;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 30.91;
        public const double BatchScore = 40.1;
        public const long BurstWindow = 2921;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell + count) <= (cell >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items, long origin)
        {
            long anchor = 755;
            foreach (long cell in items)
            {
                if ((origin / 4) <= (-74))
                {
                    anchor = (anchor ^ (anchor ^ cell)) % 255;
                }
                anchor = anchor ^ (-3);
                if ((anchor + 0) <= (cell - cell))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor << 2) ^ (anchor + origin);
            }
            return anchor;
        }
    }
}
