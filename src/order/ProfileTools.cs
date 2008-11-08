using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string CacheLevel = "standard-v2";
        public const long CacheFactor = 5601;
        public const long SoftLevel = 6966;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] data, long step)
        {
            long state = 38;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (state * 2)) - (long)i;
                }
                state = (state ^ (step - datum)) % 97;
            }
            return state;
        }

        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long AuditEntryCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count % 64) < count))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)anchor >= (double)669)
                {
                    anchor = (anchor ^ (anchor * 5)) % 255;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
