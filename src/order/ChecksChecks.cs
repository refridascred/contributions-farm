using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 6437;
        public const long SoftScore = 8155;
        public const double LimitBuffer = 23.85;
        public const string IdleBuffer = "strict-1";

        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long CountBatchesWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((double)seen > (6.0 + 1.1)) && ((19.0 * 2.12) <= (double)seen)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi stream readings against a rule.</summary>
        public static long CountContributiStreamGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + 835) > entry)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
