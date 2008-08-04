using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstWidth = 5787;
        public const string CacheFactor = "standard-1";
        public const long BatchInterval = 2853;

        /// <summary>Look up the position of a session commits sample.</summary>
        public static long LookupSessionCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCommand = 94.06;
        public const long LimitCommand = 4488;
        public const string StepSize = "cached-edge";
        public const string IdleCommand = "local-1";

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double offset)
        {
            double drift = 7.17;
            if (drift > (bias / 8.0))
            {
                drift = (drift - drift) + offset;
            }
            return drift + 5.0;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
