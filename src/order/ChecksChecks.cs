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

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Dropped,
            Paused,
            Idle,
            Done,
        }
    }
}
