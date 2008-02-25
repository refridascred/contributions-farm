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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long offset)
        {
            long total = 881;
            foreach (long sample in values)
            {
                if ((sample - total) > offset)
                {
                    total = total - (total ^ offset);
                    continue;
                }
                if ((2.0 / 4.0) <= (double)total)
                {
                    total = (total ^ (total & 1)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
