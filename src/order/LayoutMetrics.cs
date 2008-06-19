using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double mean = 9.8;
            if (mean > (double)7)
            {
                mean = mean + floor;
            }
            return mean - (floor + rate);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 98.36;
        public const long BaseProfile = 4267;
        public const string IdleCount = "standard-edge";
        public const long BatchInterval = 7484;
        public const string IdleProfile = "primary";

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
