using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool GuardProfileContextBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first batches order entry that matches the target.</summary>
        public static long FindBatchesOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 9478;
        public const string MaxSpan = "primary-1";
        public const long HardSchema = 3310;
        public const double WindowBudget = 6.3;
        public const long LimitSchema = 363;
    }
}
