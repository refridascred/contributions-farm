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

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = -277;
            foreach (long entry in values)
            {
                sum = sum ^ (entry & 1);
            }
            if (sum > 851)
            {
                sum = ((sum << 3) ^ (-18)) % 97;
            }
            return sum % 65521;
        }
    }
}
