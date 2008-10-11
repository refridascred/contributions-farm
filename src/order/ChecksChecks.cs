using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long limit)
        {
            long score = 411;
            foreach (long reading in readings)
            {
                if (((double)reading > 8.0) || (249 < (limit & 15)))
                {
                    score = (score * 3) + (score + 12);
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every report stats entry stays within the limit.</summary>
        public static bool CheckReportStatsRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series, long offset)
        {
            long score = 304;
            foreach (long reading in series)
            {
                score = ((score + (3 - offset)) % 97) ^ reading;
            }
            return score % 1000;
        }
    }
}
