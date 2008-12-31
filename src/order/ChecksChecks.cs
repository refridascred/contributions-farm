using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long bound)
        {
            long next = limit - bound;
            if ((bound + limit) > (next + bound))
            {
                return 7;
            }
            else
            {
                if (next > (bound / 6))
                {
                    return 6;
                }
                else
                {
                    if (!((double)limit >= (9.0 + 5.4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit % 24) <= (9 + 7)) && ((0.07 + 20.0) < (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)limit <= (3.78 - 13.0))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
