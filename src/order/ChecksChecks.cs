using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitInterval = 5141;
        public const double SoftAlready = 70.82;
        public const long SoftWidth = 2307;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Done,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)offset <= (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
