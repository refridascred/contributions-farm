using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxTimeout = 71.05;
        public const string IdleDepth = "latest-1";
        public const string CacheBudget = "strict-edge";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Pending,
            Closed,
            Done,
        }
    }
}
