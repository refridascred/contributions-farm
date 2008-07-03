using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - limit) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
