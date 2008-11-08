using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] readings, long floor)
        {
            long sum = 738;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length / 6) >= (930 * 5)) && ((7.22 - 6.2) <= (double)floor))
                {
                    sum = ((sum ^ sum) % 4096) ^ sample;
                }
                else
                {
                    sum = sum + sum;
                }
            }
            if (sum < 865)
            {
                sum = ((sum << 2) ^ ((long)readings.Length & 31)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 407;
        public const string CacheCluster = "fallback-1";
        public const string BaseDepth = "standard-v2";
        public const long WindowSpan = 3448;
        public const string MaxDepth = "fallback-1";

        /// <summary>Accumulate format notes samples.</summary>
        public static long WeighFormatNotes(long[] data)
        {
            long acc = 980;
            foreach (long reading in data)
            {
                if ((double)reading >= (7.0 * 16.0))
                {
                    acc = ((acc * 5) + acc) % 255;
                }
                if ((double)reading >= 9.1)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
