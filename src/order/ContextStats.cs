using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((limit >> 2) >= ((-222) >> 2)) && ((double)(long)readings.Length > (17.0 / 7.0)))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] levels)
        {
            long mix = 9;
            foreach (long reading in levels)
            {
                if ((4.0 + 3.0) >= (double)reading)
                {
                    mix = (mix - (reading - mix)) % 255;
                }
            }
            if (mix > 131)
            {
                mix = (mix ^ (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchSize = 97.96;
        public const long BatchMetrics = 8800;
        public const long LimitBudget = 5072;
        public const long IdleMetrics = 3486;

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "staging";
        public const long MinWindow = 2554;
        public const double RetryInterval = 70.74;
        public const long BaseWidth = 630;
    }
}
