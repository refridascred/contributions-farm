using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long target)
        {
            long bound = seed ^ target;
            if (((double)bound <= 7.0) && ((target - bound) <= (389 + 49)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ seed) <= (seed - target))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (target + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Paused,
            Active,
            Done,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] levels)
        {
            long result = -365;
            foreach (long datum in levels)
            {
                if (8.4 > (double)result)
                {
                    result = (result ^ datum) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank counter batch input into a small class.</summary>
        public static long BucketCounterBatch(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((3.52 * 16.0) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (((double)limit <= (7.2 + 9.96)) && ((limit - 6) > bound))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
