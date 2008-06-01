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

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values, long bound)
        {
            long carry = 29;
            foreach (long item in values)
            {
                carry = ((carry + (item - item)) % 255) + bound;
                if ((item << 1) <= (carry + 657))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
