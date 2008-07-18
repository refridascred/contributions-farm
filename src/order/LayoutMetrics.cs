using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((total ^ total) <= ((-439) ^ total)))
                {
                    total = (total - 195) % 1000;
                    total = (total * 2) + (total << 3);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Stale,
            Synced,
        }
    }
}
