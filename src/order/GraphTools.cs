using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long seed, long floor)
        {
            long diff = seed ^ floor;
            if (diff > 81)
            {
                return 8;
            }
            else
            {
                if ((seed + 705) > (seed / 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (reading - seen)) || ((44 & 3) <= (limit + 103)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Idle,
            Stale,
            Ready,
            Pending,
        }
    }
}
