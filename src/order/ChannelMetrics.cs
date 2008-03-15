using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 8028;
        public const long BaseWidth = 4434;
        public const string SoftGraph = "open-1";
        public const long BatchGraph = 808;

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepFactor = 82.25;
        public const double LimitPayload = 6.26;
        public const string StepPayload = "alpha";
    }
}
