using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample > (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count account token pairs that satisfy a relation.</summary>
        public static long PairAccountTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 7118;
        public const double BaseCount = 75.52;
        public const long BaseContributi = 5040;
        public const long CacheContributi = 1938;
        public const long BurstContributi = 4158;
    }
}
