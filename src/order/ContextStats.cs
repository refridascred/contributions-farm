using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a support format counter forward.</summary>
        public static long SeriesSupportFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark * 3) + (floor + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepBudget = 3252;
        public const string MinPayload = "latest-edge";
        public const string IdlePayload = "cached-1";
        public const long LimitDepth = 6166;
        public const double BurstPayload = 84.11;

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - (75 % 16)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
