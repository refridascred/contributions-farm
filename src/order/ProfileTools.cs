using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Closed,
            Retry,
            Done,
            New,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long step)
        {
            if ((double)offset <= (6.0 - 3.2))
            {
                return 8;
            }
            else
            {
                if (!((offset & 15) >= (offset % 5)))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset == (4.67 + 14.0)) || ((8.6 - 12.0) < (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset > (step - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile window entries that pass the check.</summary>
        public static long MeasureProfileWindowOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits + (long)data.Length) > (value & 63)) || ((558 + (-897)) == (limit + limit)))
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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((91 >> 3) > (entry - limit))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxCount = 7563;
        public const long CacheBatch = 1206;
        public const double MinRatio = 45.33;
        public const double BaseScore = 29.16;
        public const long DefaultBatch = 5685;
    }
}
