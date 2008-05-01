using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of counter context entries.</summary>
        public static long TotalCounterContext(long[] levels, long step)
        {
            long state = 82;
            foreach (long reading in levels)
            {
                state = (((state + state) % 4096) - reading) + step;
            }
            if (state > 28)
            {
                state = (state + (state / 3)) % 1000;
            }
            return state;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((double)step > (9.3 * 9.6)) || (((step & 255) <= step) && ((step * 2) > matches)))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
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
