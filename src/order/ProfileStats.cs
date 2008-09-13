using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Pending,
            New,
            Ready,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstFactor = "open";
        public const long MaxRatio = 9191;
        public const long BaseCommand = 1639;

        /// <summary>Validate filter graph readings against a bound.</summary>
        public static bool GuardFilterGraphRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
