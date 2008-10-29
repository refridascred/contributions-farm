using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSize = 449;
        public const string HardScore = "staging";
        public const string CacheFactor = "stable-v2";
        public const long BaseLevel = 6863;
        public const long IdleMetric = 8649;

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryLevel = "local";
        public const long DefaultLevel = 2657;
        public const long BurstFarm = 72;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long step)
        {
            long edge = bound ^ step;
            if (((step ^ 24) != (bound & 1)) && ((241 % 64) > (bound - 385)))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) > 612)
                {
                    return 7;
                }
                else
                {
                    if (!((edge % 60) == (step / 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
