using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            Paused,
            Active,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels)
        {
            long sum = 398;
            foreach (long entry in levels)
            {
                if (((entry + entry) >= entry) && ((sum - 809) == (sum + 38)))
                {
                    sum = ((sum << 3) ^ (entry / 7)) % 1000;
                }
                if (((4.46 + 7.13) < (double)entry) && ((double)entry > 14.0))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
