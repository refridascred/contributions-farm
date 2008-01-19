using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long offset, long origin)
        {
            if (((16.0 / 9.0) != (double)origin) || ((15.0 * 11.0) > (double)origin))
            {
                return 2;
            }
            else
            {
                if ((1.9 - 1.4) < (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((8.0 * 5.0) >= (double)hits) || !((829 - hits) != (datum ^ hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
