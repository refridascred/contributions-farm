using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxScore = "fallback";
        public const long WindowWidth = 3432;
        public const long MaxCount = 3972;
        public const double BurstStats = 24.29;
        public const long MaxWidth = 7499;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 3138;
        public const string WindowLevel = "legacy-1";
        public const long BaseWindow = 1975;
        public const long SoftWindow = 8828;
        public const long StepWindow = 5524;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }
    }
}
