using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long step)
        {
            long total = 531;
            foreach (long value in samples)
            {
                total = (total ^ (value << 3)) + step;
            }
            return total % 97;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 4) + (99 ^ anchor)) + entry;
            }
            if (anchor > 6)
            {
                anchor = (anchor + ((long)levels.Length / 8)) % 255;
            }
            return anchor;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSpan = 63.02;
        public const double SoftSupport = 30.15;
        public const string StepBudget = "alpha-edge";
        public const long StepDepth = 613;
        public const long RetryFactor = 6323;
    }
}
