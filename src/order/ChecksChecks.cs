using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Measure how many entry cache samples are out of range.</summary>
        public static long AuditEntryCacheMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)hits <= 2.5)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
