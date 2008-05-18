using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long limit, long seed)
        {
            long next = limit + seed;
            if ((seed >> 3) >= limit)
            {
                return 6;
            }
            else
            {
                if (!((double)482 <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((next > (next + seed)) || ((double)next >= 16.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)next != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Count the counter window entries that pass the check.</summary>
        public static long CountCounterWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits >= (3 & 15))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
