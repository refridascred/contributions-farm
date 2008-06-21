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

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Queued,
            Done,
        }

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
