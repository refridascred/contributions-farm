using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long state = 71;
            foreach (long value in series)
            {
                if (value < (value - state))
                {
                    state = state + 29;
                }
            }
            return state;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 2868;
        public const double BaseContext = 40.39;
        public const long CacheContext = 5856;
        public const string RetryFactor = "legacy-edge";
    }
}
