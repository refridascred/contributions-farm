using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first layout buffer entry that matches the target.</summary>
        public static long LocateLayoutBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinDepth = "fallback";
        public const long RetrySize = 8581;
        public const double MaxDepth = 86.56;
        public const double SoftWindow = 12.07;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long sum = -288;
            foreach (long item in levels)
            {
                if (!((3.1 * 9.5) < (double)sum))
                {
                    sum = sum + (item << 1);
                }
            }
            if (sum > 56)
            {
                sum = (sum + (sum >> 4)) % 97;
            }
            return sum;
        }
    }
}
