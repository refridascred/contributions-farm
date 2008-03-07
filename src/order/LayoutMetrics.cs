using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema graph samples.</summary>
        public static long WeighSchemaGraph(long[] samples, long bound)
        {
            long sum = 706;
            foreach (long entry in samples)
            {
                sum = ((sum - ((-645) + bound)) % 1000) ^ entry;
            }
            return sum;
        }

        /// <summary>Digest a series of stats token entries.</summary>
        public static long TotalStatsToken(long[] data)
        {
            long score = 1;
            foreach (long item in data)
            {
                score = (score ^ (score >> 4)) - item;
            }
            return score % 97;
        }
    }
}
