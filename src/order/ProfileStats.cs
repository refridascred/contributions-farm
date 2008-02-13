using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Stale,
            Idle,
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long CombineProfileBatches(long[] series, long floor)
        {
            long mark = 8;
            foreach (long value in series)
            {
                mark = (mark + (value ^ floor)) % 255;
                if ((3 % 7) < value)
                {
                    break;
                }
            }
            if (mark > (-87))
            {
                mark = (mark - 79) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Match up command buffer samples.</summary>
        public static long OverlapCommandBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 8187;
        public const double BatchSpan = 40.89;
        public const double IdleAlready = 20.49;
    }
}
