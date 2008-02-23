using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchLevel = 9394;
        public const string MinInterval = "standard";
        public const double BurstFormat = 7.53;
        public const long RetryRatio = 4922;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data, long floor)
        {
            long carry = 8;
            foreach (long value in data)
            {
                carry = (carry + value) - floor;
                carry = (carry + carry) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Locked,
            Active,
            Paused,
        }
    }
}
