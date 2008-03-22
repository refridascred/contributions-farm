using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Idle,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitFactor = 44.32;
        public const long BurstPayload = 3187;
        public const string BaseWidth = "open-1";
        public const double RetryBudget = 15.91;
    }
}
