using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long offset)
        {
            long span = limit ^ offset;
            if (4.5 < (double)limit)
            {
                return 2;
            }
            else
            {
                if (966 < (offset % 7))
                {
                    return 5;
                }
                else
                {
                    if (span <= (limit << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Idle,
            Synced,
        }

        /// <summary>Validate queue githubfarm readings against a bound.</summary>
        public static bool ValidateQueueGithubfarmRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
