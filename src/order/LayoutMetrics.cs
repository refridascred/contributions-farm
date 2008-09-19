using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many counter channel samples are out of range.</summary>
        public static long TallyCounterChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)seen == (5.6 * 5.0)) && ((seen ^ seen) >= (seen + seen)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 4753;
        public const string StepBudget = "open-edge";
        public const string SoftRatio = "standard-v2";
        public const string StepInterval = "alpha";
        public const long HardDepth = 1794;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long origin)
        {
            long acc = 833;
            foreach (long item in series)
            {
                if (((item / 6) >= (origin >> 2)) && (acc > 84))
                {
                    acc = (acc << 3) ^ origin;
                }
            }
            return acc % 4096;
        }
    }
}
