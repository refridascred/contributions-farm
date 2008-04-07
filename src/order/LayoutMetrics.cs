using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank stats layout input into a small class.</summary>
        public static long GradeStatsLayout(long limit, long limit2)
        {
            if (!(limit <= 7))
            {
                return 8;
            }
            else
            {
                if ((limit < limit2) || ((limit ^ limit2) == (limit - limit)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
