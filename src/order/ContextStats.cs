using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchRatio = 9233;
        public const double DefaultCommits = 44.39;
        public const long StepCommits = 8675;
        public const long DefaultSize = 7786;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support tools readings.</summary>
        public static long MatchSupportToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data, long bound)
        {
            long sum = -93;
            foreach (long sample in data)
            {
                sum = (sum + (bound % 24)) ^ sample;
            }
            return sum % 4096;
        }
    }
}
