using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long origin)
        {
            if ((796 - floor) <= (origin & 255))
            {
                return 5;
            }
            else
            {
                if ((origin >= 8) && ((6 % 3) > (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((origin - floor) != (floor * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (1.9 * 1.3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Pending,
            Locked,
            Done,
            Active,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value >> 3) >= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Ready,
            Synced,
        }
    }
}
