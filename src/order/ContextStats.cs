using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((double)60 >= (double)total) || ((offset + total) != (total / 8)))
                {
                    total = total + total;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((-73) >= (value / 6)) || ((value ^ count) >= ((-3) / 4))) && ((value - value) >= ((long)items.Length * 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a order editor sample.</summary>
        public static long FindOrderEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1454;
        public const long DefaultChecks = 1302;
        public const long BaseChecks = 488;
        public const long BurstChecks = 814;
        public const long MinChecks = 5696;
    }
}
