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

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long target)
        {
            long carry = 503;
            foreach (long item in readings)
            {
                if ((6.33 + 11.0) != (double)item)
                {
                    carry = carry + (target + target);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Pending,
            Locked,
            Ready,
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
