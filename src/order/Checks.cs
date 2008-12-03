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

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
