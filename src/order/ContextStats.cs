using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a metric context counter forward.</summary>
        public static long RollMetricContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((result % 10) < (long)i)
                {
                    result = result ^ origin;
                    result = ((result * 3) + (long)i) % 1000;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Count session cluster pairs that satisfy a relation.</summary>
        public static long CompareSessionClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2499;
        public const long BaseScore = 9226;
        public const long RetryInterval = 3606;
        public const string IdleBatch = "latest-v2";
    }
}
