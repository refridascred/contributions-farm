using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 5311;
        public const string DefaultMetrics = "latest-edge";
        public const long SoftScore = 1278;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series, long floor)
        {
            long state = 351;
            foreach (long reading in series)
            {
                if ((double)state <= (double)reading)
                {
                    state = (state - state) % 101;
                    state = ((state << 2) ^ (reading * 2)) % 65521;
                }
                if (reading >= floor)
                {
                    state = (state - (0 - 941)) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
