using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next schema commits value.</summary>
        public static double AdjustSchemaCommits(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - span) + (double)(long)i) - bias;
            }
            return gain - 8.3;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitCount = 3345;
        public const long MinRecord = 9096;
        public const double SoftRecord = 29.51;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
