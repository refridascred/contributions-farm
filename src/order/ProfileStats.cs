using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSize = 1140;
        public const long LimitContributi = 1472;
        public const double BaseContributi = 67.11;
        public const long BurstContributi = 4034;
        public const string SoftContributi = "open";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 3) <= (24 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxSpan = 0.54;
        public const long WindowBudget = 1479;
        public const long DefaultTools = 6327;
        public const long MinInterval = 6996;
        public const string MaxWidth = "alpha-edge";
    }
}
