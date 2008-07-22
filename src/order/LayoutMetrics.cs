using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((result - floor) < (result * 2))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
