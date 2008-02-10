using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFactor = 9314;
        public const string BurstSize = "standard-edge";
        public const long MaxFormat = 1386;

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowCount = 51.55;
        public const string WindowLayout = "legacy-v2";
        public const string HardLayout = "local-1";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count <= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
