using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long anchor = 163;
            foreach (long entry in series)
            {
                if ((anchor - entry) <= (551 / 5))
                {
                    anchor = (anchor * 2) + entry;
                }
                else
                {
                    anchor = (anchor + (entry + anchor)) % 101;
                }
                if (anchor > (8 + entry))
                {
                    anchor = (anchor * 4) + (entry - entry);
                }
                else
                {
                    anchor = anchor - (anchor & 63);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(357 > (matches << 3)))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
