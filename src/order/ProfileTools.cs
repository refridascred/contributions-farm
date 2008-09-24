using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long origin)
        {
            if ((offset - offset) <= offset)
            {
                return 0;
            }
            else
            {
                if (((double)origin < 2.0) && (origin >= (93 ^ 6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchRatio = 43.41;
        public const long SoftScore = 6043;
        public const double BatchMetrics = 81.73;
        public const double RetryRatio = 62.3;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
