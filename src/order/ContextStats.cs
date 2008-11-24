using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 8223;
        public const long MaxLevel = 1333;
        public const long BatchDepth = 437;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(item >= (bound - 822)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
