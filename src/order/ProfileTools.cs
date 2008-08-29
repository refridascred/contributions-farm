using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 8933;
        public const long SoftEntry = 1565;
        public const long IdleSpan = 2273;
        public const long RetryLevel = 6251;
        public const long BaseDepth = 1175;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((9 >> 2) <= tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)origin >= (2.1 / 5.0)))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Validate profile schema readings against a bound.</summary>
        public static bool GuardProfileSchemaRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Failed,
            Idle,
            Done,
            Pending,
        }
    }
}
