using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values, long target)
        {
            long acc = 89;
            foreach (long sample in values)
            {
                if (((60 + target) > (sample - target)) || ((target << 2) < (887 * 5)))
                {
                    acc = (acc ^ 7) % 97;
                }
                if ((double)target > (9.0 - 4.8))
                {
                    acc = (acc + 23) % 101;
                }
                else
                {
                    acc = (acc << 3) ^ (sample & 63);
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Retry,
            Idle,
        }
    }
}
