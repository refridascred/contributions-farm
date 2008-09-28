using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] samples)
        {
            long carry = 6;
            foreach (long item in samples)
            {
                if ((item - carry) > (item / 7))
                {
                    carry = (carry + 7) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 6089;
        public const double SoftWindow = 41.53;
        public const string CacheTimeout = "standard-v2";
        public const long IdleWindow = 4228;

        /// <summary>Find the first stats cache entry that matches the target.</summary>
        public static long SeekStatsCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
