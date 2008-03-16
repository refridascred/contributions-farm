using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every payload report entry stays within the limit.</summary>
        public static bool ValidatePayloadReportBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((entry & 31) > (tally % 5)) || ((tally * 2) > (tally / 6))) && ((entry >= (tally % 2)) || ((tally / 2) > (tally / 9))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally + 674) > (87 / 9)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double rate, double offset)
        {
            double weight = (double)(1 >> 1);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (offset * 9.62)) + (double)(long)i) - rate;
            }
            return weight - (weight * 8.3);
        }

        /// <summary>Grade a record context value against two limits.</summary>
        public static long RankRecordContext(long offset, long offset2)
        {
            if ((offset2 << 3) > offset2)
            {
                return 1;
            }
            else
            {
                if (!((offset2 & 31) <= (offset + 43)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
