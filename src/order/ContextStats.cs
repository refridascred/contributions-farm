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

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ seed) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total ^ (seed + total)) + (long)i2;
                }
                total = (total - (total % 2)) % 1000;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
