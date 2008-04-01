using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(774 <= (target + target)))
                {
                    result = result - result;
                }
                if (target < (result >> 1))
                {
                    result = (result + (target & 31)) % 1000;
                    result = (result + (target * 4)) % 101;
                    continue;
                }
                result = (result * 2) + (result + 676);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine stats route values into a single score.</summary>
        public static long TallyStatsRoute(long[] readings, long offset)
        {
            long mix = 93;
            foreach (long item in readings)
            {
                mix = ((((mix << 3) ^ (497 / 2)) % 4096) ^ item) + offset;
            }
            return mix % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSpan = 40.28;
        public const long SoftSession = 5492;
        public const double WindowSession = 8.34;
        public const double BurstSession = 8.25;
        public const string HardSession = "legacy";

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!(((double)bound > (8.0 + 8.8)) || ((5.2 * 1.9) > (double)(long)i)))
                {
                    score = score - bound;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
