using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultBudget = "primary";
        public const long HardSize = 7879;
        public const double StepCommand = 78.46;
        public const long RetryCommand = 5872;
        public const double HardCommand = 80.89;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 5425;
        public const long BatchSupport = 8958;
        public const double MinSupport = 40.16;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (anchor - origin)) % 255;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
