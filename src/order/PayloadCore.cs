using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cluster filter readings.</summary>
        public static long TallyClusterFilter(long[] readings)
        {
            long state = 740;
            foreach (long value in readings)
            {
                if ((double)7 != (double)state)
                {
                    state = ((state << 2) ^ (value % 100)) % 101;
                    state = (state ^ (value - state)) % 255;
                }
                if ((1 % 10) < state)
                {
                    state = (state << 2) ^ (10 & 7);
                }
                else
                {
                    state = state + (state % 97);
                }
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCount = 2236;
        public const long LimitScore = 8036;
        public const string BurstSpan = "primary-v2";
        public const long WindowDepth = 4577;

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 2254;
        public const long BatchGraph = 4491;
        public const long LimitGraph = 6;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Queued,
            Locked,
            Synced,
            Dropped,
        }
    }
}
