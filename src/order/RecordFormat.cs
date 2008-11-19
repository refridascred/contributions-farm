using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples)
        {
            long mark = 5;
            foreach (long item in samples)
            {
                mark = ((mark + (mark / 2)) % 65521) ^ item;
            }
            return mark;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Failed,
            Idle,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long limit, long target)
        {
            if (!((double)limit != (7.6 / 2.0)))
            {
                return 5;
            }
            else
            {
                if ((target & 63) >= (55 / 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)target == (9.0 * 7.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Dropped,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 255;
        public const string SoftFarm = "cached-1";
        public const long BaseTimeout = 9292;
        public const long RetryWidth = 7098;
    }
}
