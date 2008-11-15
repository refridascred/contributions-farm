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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
