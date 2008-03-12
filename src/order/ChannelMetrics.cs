using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((double)hits > (double)700))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 93.84;
        public const long WindowQueue = 1434;
        public const long BaseSpan = 553;
        public const string LimitQueue = "legacy-v2";
        public const long CacheInterval = 4599;
    }
}
