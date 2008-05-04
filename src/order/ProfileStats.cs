using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Fold a list of entry window readings.</summary>
        public static long FoldEntryWindow(long[] readings)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if (!((11.0 / 6.0) == (double)item))
                {
                    carry = ((carry * 2) + item) % 1000;
                }
                else
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
                if ((11.0 + 4.78) == (double)item)
                {
                    break;
                }
            }
            if (carry > 32)
            {
                carry = ((carry * 3) + (990 - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 3719;
        public const long CacheCommand = 9940;
        public const double SoftTimeout = 62.71;
        public const double SoftCommand = 34.67;
        public const long SoftSize = 1009;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
