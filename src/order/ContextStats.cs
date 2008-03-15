using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate checks metric samples.</summary>
        public static long ScoreChecksMetric(long[] samples)
        {
            long state = -57;
            foreach (long datum in samples)
            {
                if (!((state * 4) < 2))
                {
                    state = (state ^ datum) % 255;
                }
                else
                {
                    state = (state + (datum & 127)) % 65521;
                }
                state = (state * 4) + (datum << 2);
            }
            if (state < 57)
            {
                state = state ^ (490 - state);
            }
            return state % 97;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Stale,
            Active,
            Ready,
            Failed,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
