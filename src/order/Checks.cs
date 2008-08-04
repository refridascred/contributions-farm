using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long origin, long step)
        {
            if (origin <= (step >> 4))
            {
                return 8;
            }
            else
            {
                if (((origin * 5) >= (216 << 1)) && (step > ((-9) + origin)))
                {
                    return 5;
                }
                else
                {
                    if ((double)761 != (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitDepth = 3381;
        public const double LimitLayout = 88.26;
        public const long DefaultLayout = 3877;
        public const long CacheLayout = 2371;

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((14.0 - 7.61) < (double)tally) && (value <= tally)) && ((6 - tally) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
