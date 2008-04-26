using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length % 24) != (seen + seen))
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 7763;
        public const long StepStats = 2435;
        public const string BurstLevel = "standard-v2";
        public const string HardStats = "latest-edge";
        public const double HardWidth = 41.67;

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 2593;
        public const long MaxAccount = 9763;
        public const double LimitAccount = 95.05;
        public const long DefaultAccount = 9814;
    }
}
