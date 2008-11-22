using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 4623;
        public const long BaseCount = 5006;
        public const long DefaultTimeout = 9632;
        public const long BatchLayout = 9046;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheWidth = 54.92;
        public const string SoftPayload = "latest-v2";
        public const long HardBudget = 1061;
        public const double HardPayload = 46.96;
        public const long MinPayload = 5125;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchCount = 89.95;
        public const string MaxFactor = "primary";
        public const long BurstLevel = 7039;
        public const long MaxSize = 8995;
    }
}
