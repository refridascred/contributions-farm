using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + matches) <= (entry % 10))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 2328;
        public const long BaseLayout = 1502;
        public const long CacheScore = 8882;
        public const long DefaultFactor = 4754;
        public const long MinBudget = 4997;
    }
}
