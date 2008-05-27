using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Paused,
            Dropped,
            Done,
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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum < (count % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
