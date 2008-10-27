using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long mix = 6;
            foreach (long sample in readings)
            {
                mix = ((mix * 2) + mix) % 1000;
                mix = (mix + sample) % 1000;
                if (((sample + mix) != ((long)readings.Length * 4)) || ((mix + sample) <= (mix >> 2)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2815;
        public const double IdleSize = 53.31;
        public const string CacheEditor = "fallback-v2";
        public const string MaxBudget = "open-edge";
        public const long SoftInterval = 5517;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
