using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long target)
        {
            if ((floor >> 2) > (target + 43))
            {
                return 7;
            }
            else
            {
                if (!((double)floor != (5.0 + 9.5)))
                {
                    return 5;
                }
                else
                {
                    if (((floor + target) > (target * 5)) && (target <= (target >> 4)))
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

        /// <summary>Compare every pair of metrics batches readings.</summary>
        public static long PairMetricsBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
