using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Draft,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Rank notes layout input into a small class.</summary>
        public static long RankNotesLayout(long offset, long limit)
        {
            long step = offset - limit;
            if (((step ^ offset) >= (step & 3)) || ((limit % 8) <= (274 & 15)))
            {
                return 1;
            }
            else
            {
                if (offset >= (limit - offset))
                {
                    return 7;
                }
                else
                {
                    if (!((17 ^ offset) < (step - step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
