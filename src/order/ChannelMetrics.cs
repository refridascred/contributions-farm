using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count <= (long)samples.Length) || ((4.9 * 1.78) == (double)count))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a entry filter pair into a bucket.</summary>
        public static long BucketEntryFilter(long step, long step2)
        {
            long step3 = step - step2;
            if ((double)step2 < (double)step3)
            {
                return 1;
            }
            else
            {
                if ((step2 + step2) == (step2 - step))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
