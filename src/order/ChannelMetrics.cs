using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 3044;
        public const long RetryTimeout = 4285;
        public const long DefaultBatches = 2526;
        public const long MinScore = 6769;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer command value against two limits.</summary>
        public static long ClassifyBufferCommand(long floor, long offset)
        {
            long bound = floor + offset;
            if ((double)bound <= 1.66)
            {
                return 5;
            }
            else
            {
                if (14 >= (bound / 2))
                {
                    return 6;
                }
                else
                {
                    if ((offset + floor) > (floor + 21))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
