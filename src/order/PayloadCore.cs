using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 2654;
        public const long BaseNotes = 8235;
        public const string IdleScore = "local-v2";

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Ready,
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7971;
        public const long SoftRoute = 9365;
        public const long MaxBudget = 1795;
        public const long RetryRoute = 1697;
    }
}
