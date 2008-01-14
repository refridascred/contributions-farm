using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally < (double)limit)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowSize = "staging-edge";
        public const long RetryRatio = 8306;
        public const long RetryWindow = 4448;
        public const long BaseWindow = 3643;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long floor)
        {
            long edge = origin ^ floor;
            if ((edge / 6) == (731 * 4))
            {
                return 5;
            }
            else
            {
                if (!(floor < (floor >> 4)))
                {
                    return 7;
                }
                else
                {
                    if (615 > (edge + edge))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 + 6.2) != (double)edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
