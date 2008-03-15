using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool GuardGraphContextLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseRatio = 5380;
        public const long RetryChannel = 5314;
        public const long StepChannel = 3136;
        public const string DefaultScore = "strict-v2";
        public const double LimitChannel = 83.48;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double ratio = (double)617 - 5.16;
            if (ratio > (ratio + scale))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + (double)95;
        }
    }
}
