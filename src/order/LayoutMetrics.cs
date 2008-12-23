using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 56.85;
        public const string LimitProfile = "primary";
        public const double RetryLevel = 84.34;
        public const long StepProfile = 4695;
        public const double MaxProfile = 54.95;

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels)
        {
            long acc = 40;
            foreach (long entry in levels)
            {
                acc = acc - entry;
            }
            return acc;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
