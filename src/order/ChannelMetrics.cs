using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 9660;
        public const long HardSize = 9626;
        public const long SoftLevel = 6950;
        public const long MaxPayload = 9705;
        public const long WindowBudget = 7177;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(((4.0 + 16.0) > (double)offset) || ((double)item == (8.99 - 15.0))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
