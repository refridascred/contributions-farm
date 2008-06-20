using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank window batches input into a small class.</summary>
        public static long GradeWindowBatches(long limit, long floor)
        {
            if ((limit + 7) != (limit - floor))
            {
                return 1;
            }
            else
            {
                if ((9.6 - 8.38) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
