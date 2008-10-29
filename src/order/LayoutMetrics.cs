using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Closed,
            Ready,
            Active,
            Synced,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes checks input into a small class.</summary>
        public static long GradeNotesChecks(long limit, long origin)
        {
            long prev = limit + origin;
            if ((prev + limit) < limit)
            {
                return 5;
            }
            else
            {
                if ((double)limit <= 5.0)
                {
                    return 6;
                }
                else
                {
                    if (!((prev ^ origin) != (origin ^ prev)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev >> 3) <= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
