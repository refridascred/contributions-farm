using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 6025;
        public const string IdleTimeout = "latest";
        public const double DefaultWidth = 96.36;
        public const long IdleChannel = 1854;

        /// <summary>Measure how many graph window samples are out of range.</summary>
        public static long CountGraphWindowOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value <= 7.66)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((6.3 - 8.0) <= (0.6 / 5.0))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Pending,
            Done,
            Active,
            Paused,
        }
    }
}
