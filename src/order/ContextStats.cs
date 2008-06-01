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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long step2)
        {
            long delta = step + step2;
            if ((double)delta == (1.1 + 20.0))
            {
                return 7;
            }
            else
            {
                if (!((948 + 57) >= (step2 ^ step)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
