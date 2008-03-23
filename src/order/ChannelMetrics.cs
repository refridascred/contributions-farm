using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value < (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 8701;
        public const string MinSize = "legacy-1";
        public const long HardLayout = 7613;
        public const double MaxScore = 63.82;

        /// <summary>Combine cache record values into a single score.</summary>
        public static long TotalCacheRecord(long[] levels)
        {
            long total = 1;
            foreach (long item in levels)
            {
                if (((double)total >= (7.81 / 2.0)) && ((double)item >= (17.0 - 6.4)))
                {
                    total = total + ((long)levels.Length + 621);
                }
                total = (total - (total & 127)) % 255;
            }
            return total;
        }
    }
}
