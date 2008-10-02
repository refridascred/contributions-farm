using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 626;
        public const double IdleProfile = 82.44;
        public const string BatchProfile = "staging";
        public const long BurstProfile = 9249;
        public const string CacheRatio = "stable";

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 88.24;
        public const long IdleFactor = 4365;
        public const double BurstReport = 96.56;
        public const string IdleReport = "alpha-1";
        public const long RetryInterval = 6234;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
