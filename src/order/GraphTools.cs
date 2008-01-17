using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Active,
            Retry,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((2.9 - 4.9) >= (double)value))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9039;
        public const double CacheChecks = 32.0;
        public const string BaseChecks = "alpha-v2";
        public const long SoftChecks = 5719;
    }
}
