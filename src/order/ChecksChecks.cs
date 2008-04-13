using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Draft,
            Locked,
            Idle,
            New,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                state = (((state ^ 593) % 65521) - reading) - seed;
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
