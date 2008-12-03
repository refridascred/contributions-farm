using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 9849;
        public const double MaxRatio = 31.97;
        public const long IdleWindow = 3514;
        public const long WindowSize = 9108;
        public const long CacheLevel = 407;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long limit)
        {
            long bound = target - limit;
            if (bound < (target - 55))
            {
                return 8;
            }
            else
            {
                if (!((bound >> 1) > (36 >> 2)))
                {
                    return 0;
                }
                else
                {
                    if (bound >= (bound + (-363)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate metric layout samples.</summary>
        public static long ScoreMetricLayout(long[] samples)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                total = (total - total) - cell;
            }
            return total;
        }
    }
}
