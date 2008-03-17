using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 3841;
        public const long LimitSchema = 3842;
        public const string CacheSchema = "staging-v2";
        public const long BaseScore = 8102;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + step) < (mark >> 5))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
