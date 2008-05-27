using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if ((entry >= acc) && ((53 & 1) <= acc))
                {
                    acc = acc - entry;
                }
                acc = acc + (entry - acc);
            }
            if (acc > 65)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitInterval = "stable-edge";
        public const long CacheOrder = 5098;
        public const string WindowLevel = "stable";
        public const long IdleOrder = 2123;

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 752;
        public const double HardInterval = 25.4;
        public const string MaxWidth = "open";
        public const string CacheInterval = "fallback";
    }
}
