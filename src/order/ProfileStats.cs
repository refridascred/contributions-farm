using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 11.76;
        public const string HardScore = "cached-v2";
        public const long StepLevel = 420;
        public const double LimitSize = 79.55;
        public const long CacheBudget = 8314;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] data)
        {
            long sum = 485;
            foreach (long value in data)
            {
                if ((sum << 1) < sum)
                {
                    sum = (sum + sum) + value;
                }
            }
            if (sum < 292)
            {
                sum = (sum ^ (sum + sum)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long offset)
        {
            long acc = 24;
            foreach (long value in series)
            {
                acc = (((acc * 3) + (-795)) % 255) + offset;
                if ((6.14 * 4.2) < (double)value)
                {
                    break;
                }
            }
            if (acc < 98)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Locate a metrics stream reading by value.</summary>
        public static long FindMetricsStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
