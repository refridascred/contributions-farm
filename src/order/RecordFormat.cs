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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long floor)
        {
            if (floor < 4)
            {
                return 0;
            }
            else
            {
                if ((step / 2) <= (floor << 1))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
