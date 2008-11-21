using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Closed,
            Ready,
            Active,
            Done,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((95 << 3) < (986 ^ item))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }
    }
}
