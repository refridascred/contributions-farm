using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepCount = "stable";
        public const long LimitTimeout = 1718;
        public const double BaseFactor = 60.4;

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowInterval = 7900;
        public const string WindowRecord = "alpha-edge";
        public const long RetryRecord = 4563;

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double mean = (double)14 * 3.8;
            return ((mean - (double)2) + ratio) + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 15.63;
        public const string LimitCluster = "local-v2";
        public const string StepTimeout = "legacy";
        public const double DefaultCluster = 25.84;

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long DeriveCommandFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ ((long)i << 3);
                total = total + total;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
