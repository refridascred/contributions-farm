using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many tools format samples are out of range.</summary>
        public static long AuditToolsFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count >= (count + 68))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
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
