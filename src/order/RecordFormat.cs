using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long target)
        {
            if ((52 % 2) <= (floor / 8))
            {
                return 8;
            }
            else
            {
                if (target < (-37))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (double)4)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target > floor) || ((3 + floor) >= 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
