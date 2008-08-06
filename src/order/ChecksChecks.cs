using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long CountChannelBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + value) > (581 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "legacy-edge";
        public const long RetryCommand = 8901;
        public const double LimitTimeout = 10.54;
        public const long BurstInterval = 6458;
    }
}
