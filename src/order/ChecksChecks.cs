using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of session metric readings.</summary>
        public static long CompareSessionMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 4266;
        public const long MaxSupport = 2095;
        public const double IdleTimeout = 25.48;
        public const long StepSpan = 4525;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 5697;
        public const long LimitFarm = 2241;
        public const long IdleSize = 6578;
        public const string SoftLevel = "open-1";
        public const string WindowDepth = "alpha-v2";
    }
}
