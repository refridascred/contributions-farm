using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate payload queue readings against a bound.</summary>
        public static bool ValidatePayloadQueueLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next context stats value from a seed.</summary>
        public static long IterateContextStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of filter commits entries.</summary>
        public static long TotalFilterCommits(long[] readings)
        {
            long sum = 78;
            foreach (long value in readings)
            {
                sum = sum - (170 + value);
            }
            if (sum > 154)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }
    }
}
