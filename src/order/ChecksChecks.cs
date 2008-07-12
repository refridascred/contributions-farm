using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            New,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seed < 174)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count <= (7.95 / 5.0))
                {
                    count = ((count + 2) + entry) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
