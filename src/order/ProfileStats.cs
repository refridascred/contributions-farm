using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate notes channel readings against a bound.</summary>
        public static bool CheckNotesChannelBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (target > (target % 60))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi report samples.</summary>
        public static long FoldContributiReport(long[] values, long step)
        {
            long anchor = 914;
            foreach (long reading in values)
            {
                anchor = (anchor + (step << 2)) - reading;
                if ((double)(long)values.Length > (double)444)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Idle,
            Retry,
            Locked,
            Draft,
        }
    }
}
