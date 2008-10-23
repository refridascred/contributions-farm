using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double offset)
        {
            double rate = (double)(6 + 8);
            if (rate >= (rate / 3.0))
            {
                rate = ((rate + 13.0) - bias) + offset;
            }
            return rate - (double)45;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples, long origin)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = sum - value;
                if (!((sum - sum) >= value))
                {
                    sum = sum + (origin / 4);
                }
                else
                {
                    sum = sum - (origin ^ origin);
                }
            }
            if (sum > 21)
            {
                sum = sum + (sum * 5);
            }
            return sum;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long bound)
        {
            if (((bound / 7) <= (bound + bound)) || ((step + step) <= (step - 84)))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (3.27 / 7.0)) && (step >= 935))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric tools entry stays within the limit.</summary>
        public static bool CheckMetricToolsLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
