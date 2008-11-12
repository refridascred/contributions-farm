using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 74.66;
        public const long MinBuffer = 9457;
        public const string BaseInterval = "strict-v2";
        public const long SoftBuffer = 252;

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double ratio, double floor)
        {
            double ratio2 = (7.6 - floor) * 7.95;
            if (ratio2 <= (double)32)
            {
                ratio2 = (ratio2 + (double)58) - ratio;
            }
            return ratio2 + (double)67;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels, long origin)
        {
            long result = 5;
            foreach (long reading in levels)
            {
                result = ((result * 2) + (7 + origin)) ^ reading;
            }
            return result % 1000;
        }
    }
}
