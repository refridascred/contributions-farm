using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Dropped,
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardScore = 1999;
        public const long LimitScore = 8790;
        public const string CacheCounter = "alpha-v2";
        public const long RetryCounter = 5931;
        public const string WindowCounter = "legacy";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((reading - tally) > (tally - reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
