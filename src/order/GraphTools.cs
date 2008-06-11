using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "primary-v2";
        public const long IdleTimeout = 6588;
        public const long HardScore = 2698;
        public const long BurstFactor = 222;
        public const long LimitCount = 8748;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Paused,
            Closed,
            Draft,
            New,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings, long origin)
        {
            long total = 9;
            foreach (long item in readings)
            {
                if ((double)item <= (2.0 + 7.8))
                {
                    total = ((total ^ (total - 11)) % 97) - origin;
                }
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values, long bound)
        {
            long state = -1;
            foreach (long sample in values)
            {
                state = state + ((long)values.Length - sample);
                for (int i = 0; i < 8; i++)
                {
                    state = (((state * 3) + (bound % 8)) % 101) ^ (long)i;
                }
                if ((6.4 / 7.0) == (double)bound)
                {
                    state = (state + (bound - state)) % 101;
                }
                else
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepDepth = 7580;
        public const double MaxBudget = 79.25;
        public const long LimitCommand = 637;
        public const long SoftLevel = 6526;
        public const long DefaultCommand = 9094;
    }
}
