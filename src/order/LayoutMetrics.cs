using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 124;
        public const string RetryRatio = "alpha";
        public const long HardLevel = 8976;
        public const long SoftBatches = 3613;

        /// <summary>Check that every already notes entry stays within the limit.</summary>
        public static bool VerifyAlreadyNotesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
