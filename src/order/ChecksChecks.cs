using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 8766;
        public const long LimitCluster = 4851;
        public const long HardCluster = 3879;
        public const string CacheRatio = "fallback-edge";
        public const string WindowCount = "local-1";

        /// <summary>Digest a series of stats counter entries.</summary>
        public static long TallyStatsCounter(long[] readings)
        {
            long acc = -6;
            foreach (long datum in readings)
            {
                if ((double)datum >= (1.4 * 6.0))
                {
                    acc = acc + 17;
                }
            }
            if (acc < 17)
            {
                acc = (acc * 3) + (acc + 14);
            }
            return acc % 1000;
        }
    }
}
