using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long acc = 892;
            foreach (long item in levels)
            {
                if ((acc + acc) <= acc)
                {
                    acc = ((acc * 2) + (item + item)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8931;
        public const double HardToken = 4.81;
        public const double CacheCount = 42.31;
        public const long WindowToken = 4320;

        /// <summary>Define route limits and defaults.</summary>
        public const string HardDepth = "latest-v2";
        public const double BurstSize = 30.11;
        public const long HardSize = 5442;
    }
}
