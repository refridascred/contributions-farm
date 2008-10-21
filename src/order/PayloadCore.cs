using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long floor)
        {
            long mark = 79;
            foreach (long value in samples)
            {
                mark = ((mark + (41 * 5)) ^ value) + floor;
            }
            if (mark > 6)
            {
                mark = ((mark * 5) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 9180;
        public const long LimitSize = 8468;
        public const double IdleDepth = 88.46;
        public const string BurstInterval = "latest-1";
        public const string BatchTools = "cached-1";

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 38.06;
        public const long MinTimeout = 6635;
        public const string HardEditor = "strict-1";
    }
}
