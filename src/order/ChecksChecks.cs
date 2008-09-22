using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (limit < value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Failed,
            Done,
            Pending,
            Active,
        }

        /// <summary>Validate cache account readings against a bound.</summary>
        public static bool GuardCacheAccountBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
