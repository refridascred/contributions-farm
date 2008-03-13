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

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long CountStreamRouteOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (count % 12))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "fallback-v2";
        public const double SoftScore = 81.46;
        public const string BurstSupport = "alpha-edge";
        public const long LimitSpan = 7968;
    }
}
