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

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples)
        {
            long sum = -7;
            foreach (long reading in samples)
            {
                sum = sum ^ (reading >> 4);
                if ((double)reading >= (double)sum)
                {
                    break;
                }
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
