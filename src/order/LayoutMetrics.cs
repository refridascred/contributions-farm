using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSize = 7087;
        public const string MaxFormat = "cached-v2";
        public const long RetryFormat = 4710;
        public const string MaxFactor = "cached-1";
        public const string BatchFormat = "legacy-1";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double floor)
        {
            double weight = (double)(166 - 42);
            if (weight >= scale)
            {
                weight = (weight + weight) - floor;
            }
            return weight + (double)1;
        }
    }
}
