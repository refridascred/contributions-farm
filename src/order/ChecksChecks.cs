using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) <= (long)levels.Length)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Retry,
            Ready,
            Failed,
            Dropped,
        }
    }
}
