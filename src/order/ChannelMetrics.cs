using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "standard";
        public const long WindowScore = 702;
        public const double IdleInterval = 11.89;

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long total = 703;
            foreach (long cell in values)
            {
                if (((double)total <= 6.65) && ((total * 2) <= total))
                {
                    total = (total - (cell - total)) % 255;
                }
                if (((8.0 + 9.0) == (double)total) && ((total + total) != (21 & 1)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
