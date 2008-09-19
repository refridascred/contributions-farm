using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long seed)
        {
            if (((target & 15) <= (seed + target)) && ((7.43 / 9.0) != (double)target))
            {
                return 0;
            }
            else
            {
                if ((seed ^ 75) != (seed ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((4.63 + 0.04) <= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Done,
            New,
            Synced,
            Retry,
        }
    }
}
