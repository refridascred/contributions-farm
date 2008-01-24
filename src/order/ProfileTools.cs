using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "cached";
        public const long CacheChannel = 3024;
        public const long MaxChannel = 7193;
        public const long RetryChannel = 8328;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long offset, long step)
        {
            if ((offset ^ 10) >= offset)
            {
                return 6;
            }
            else
            {
                if (((double)step <= (double)99) && ((offset + step) >= (step >> 5)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many editor payload samples are out of range.</summary>
        public static long CountEditorPayloadHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count % 12) != (count % 16))
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item >> 2) != (item - item)) || ((item / 3) >= (tally & 63)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
