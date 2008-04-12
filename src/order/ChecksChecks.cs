using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Draft,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Locked,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Measure how many editor batches samples are out of range.</summary>
        public static long TallyEditorBatchesMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((9.69 + 2.0) == (double)value)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
