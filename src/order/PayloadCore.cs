using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long step)
        {
            if (((origin >> 4) == (step ^ 12)) || ((2.04 + 3.1) <= (double)step))
            {
                return 8;
            }
            else
            {
                if ((double)origin == (5.0 + 5.34))
                {
                    return 3;
                }
                else
                {
                    if ((origin + origin) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long TallyCacheAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item < 60)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
