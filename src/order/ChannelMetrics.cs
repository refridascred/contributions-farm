using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm batches input into a small class.</summary>
        public static long ClassifyFarmBatches(long target, long target2)
        {
            long diff = target ^ target2;
            if ((double)target < (1.4 * 6.1))
            {
                return 3;
            }
            else
            {
                if (target2 < ((-491) % 97))
                {
                    return 0;
                }
                else
                {
                    if ((diff - target2) != (diff / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
