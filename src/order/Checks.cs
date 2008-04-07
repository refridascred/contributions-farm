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

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 9385;
        public const long BatchCount = 4466;
        public const long WindowSize = 9545;
        public const long MaxSize = 5760;
        public const double CacheFormat = 61.61;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - target) == (target << 1))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

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
