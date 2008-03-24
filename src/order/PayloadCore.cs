using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading > (hits + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Ready,
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data, long floor)
        {
            long state = 91;
            foreach (long cell in data)
            {
                state = ((state + 949) % 1000) + floor;
                if ((3 + state) >= (cell + cell))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Stale,
            Locked,
            Retry,
        }
    }
}
