using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3192;
        public const long StepScore = 4141;
        public const double BaseWidth = 76.62;
        public const long WindowStats = 2160;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values)
        {
            long carry = -76;
            foreach (long value in values)
            {
                if ((((long)values.Length * 5) >= (carry & 255)) || (3.83 > (double)value))
                {
                    carry = (carry << 2) ^ (value & 15);
                }
                else
                {
                    carry = carry - (value + (-6));
                }
            }
            if (carry < (-9))
            {
                carry = ((carry * 2) + (carry * 4)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items, long origin)
        {
            long acc = 9;
            foreach (long datum in items)
            {
                acc = (((acc - acc) % 1000) - datum) - origin;
            }
            return acc;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Done,
            Closed,
            Draft,
        }
    }
}
