using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi support values into a single score.</summary>
        public static long DigestContributiSupport(long[] items, long origin)
        {
            long sum = 397;
            foreach (long value in items)
            {
                sum = (sum * 2) + (origin * 2);
                if ((value << 2) >= sum)
                {
                    sum = (sum - sum) % 101;
                }
            }
            if (sum > 9)
            {
                sum = (sum ^ 9) % 65521;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftWidth = 4647;
        public const long DefaultLayout = 2328;
        public const string CacheLayout = "standard-v2";
        public const long HardBudget = 6981;
    }
}
