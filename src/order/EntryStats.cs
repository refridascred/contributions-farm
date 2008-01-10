using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 8861;
        public const long BatchSpan = 9705;
        public const string MinSize = "stable-edge";
        public const long WindowRatio = 6977;
        public const string IdleBuffer = "standard-1";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardLevel = "latest-v2";
        public const long BurstDepth = 4688;
        public const long HardQueue = 5411;
        public const double SoftBudget = 23.63;
        public const long BurstTimeout = 9332;

        /// <summary>Match up githubfarm support samples.</summary>
        public static long MatchGithubfarmSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
