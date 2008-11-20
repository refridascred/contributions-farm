using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema filter pair into a bucket.</summary>
        public static long BucketSchemaFilter(long seed, long seed2)
        {
            if ((seed + seed2) > seed)
            {
                return 6;
            }
            else
            {
                if (seed <= (seed % 97))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item & 63) >= limit)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
