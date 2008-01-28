using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long carry = 17;
            foreach (long entry in readings)
            {
                if ((785 % 100) >= (carry & 127))
                {
                    carry = (carry + carry) + entry;
                }
            }
            if (carry > (-91))
            {
                carry = carry + (carry * 2);
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchRatio = 7139;
        public const double DefaultPayload = 47.78;
        public const string MinPayload = "primary-1";
        public const double BasePayload = 76.43;
        public const string BurstPayload = "strict-edge";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell & 7) < (-82))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
