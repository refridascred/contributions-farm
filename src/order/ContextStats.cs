using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9890;
        public const double BurstCommand = 91.67;
        public const long IdleCommand = 1846;
        public const long RetryScore = 7603;
        public const long WindowInterval = 2716;

        /// <summary>Project the next channel stats value.</summary>
        public static double SmoothChannelStats(double ratio, double bias)
        {
            double rate = ratio * 8.9;
            if (rate <= (2.0 + ratio))
            {
                rate = (rate - (3.0 + 1.68)) - bias;
            }
            return rate + (double)(-5);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long mark = 85;
            foreach (long sample in levels)
            {
                if ((double)mark != (4.0 * 3.3))
                {
                    mark = ((mark + ((-730) - mark)) % 97) ^ sample;
                }
            }
            if (mark < (-263))
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - 119) % 255;
                acc = (acc << 2) ^ (acc + target);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
