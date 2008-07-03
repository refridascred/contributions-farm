using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long origin)
        {
            if ((step <= (8 - step)) && ((origin / 4) == (origin % 100)))
            {
                return 4;
            }
            else
            {
                if (!(1 > origin))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
