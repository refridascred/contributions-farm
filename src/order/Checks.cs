using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long LocateBatchCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally ^ origin) != (origin >> 3)) && ((28 > (4 - sample)) || ((origin + sample) <= (origin - sample))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long target)
        {
            long cur = seed ^ target;
            if ((cur ^ cur) >= (target % 8))
            {
                return 2;
            }
            else
            {
                if ((target + seed) == (seed ^ cur))
                {
                    return 1;
                }
                else
                {
                    if ((double)target < (2.0 * 16.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur / 9) != (target - target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (double)41)
            {
                scale = (scale + (ratio / 3.0)) - floor;
            }
            return scale + scale;
        }
    }
}
