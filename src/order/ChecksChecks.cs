using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long floor)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = (result + result) % 101;
                result = result ^ entry;
                result = (result ^ (7 - floor)) % 4096;
            }
            if (result < 8)
            {
                result = result + (4 ^ result);
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "standard";
        public const long MinLayout = 3053;
        public const double MaxLayout = 73.33;
        public const string BaseTimeout = "standard";
        public const long LimitLayout = 6986;

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 6625;
        public const double BurstEditor = 16.67;
        public const long HardDepth = 8317;
        public const long RetrySize = 4683;
    }
}
