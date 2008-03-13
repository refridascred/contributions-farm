using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long ScoreToolsContributi(long[] samples)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                if ((carry + carry) < (carry - entry))
                {
                    carry = ((carry << 2) ^ (16 % 3)) % 101;
                }
                else
                {
                    carry = (carry * 4) + ((long)samples.Length + carry);
                }
            }
            return carry;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + (mark + floor);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "fallback-v2";
        public const double SoftScore = 81.46;
        public const string BurstSupport = "alpha-edge";
        public const long LimitSpan = 7968;
    }
}
