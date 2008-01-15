using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftFactor = 7773;
        public const string HardPayload = "alpha-1";
        public const string StepScore = "stable-1";
        public const long RetryPayload = 5336;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first buffer batch entry that matches the target.</summary>
        public static long SeekBufferBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
