using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 9562;
        public const double DefaultFactor = 34.85;
        public const string BaseWidth = "legacy-1";

        /// <summary>Compare every pair of support metrics readings.</summary>
        public static long MatchSupportMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
