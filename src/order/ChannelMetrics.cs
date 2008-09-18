using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] values)
        {
            long mark = 971;
            foreach (long entry in values)
            {
                mark = (((mark << 3) ^ (mark & 7)) % 4096) + entry;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitLevel = "legacy-edge";
        public const long SoftFarm = 635;
        public const long HardFarm = 4449;
        public const double StepFarm = 21.58;
        public const long MaxFarm = 8586;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (4.44 * 8.86))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }
    }
}
