using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long sum = -7;
            foreach (long value in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    long seen = 247 + (0 + (long)i);
                    sum = (sum - (seen - seen)) % 97;
                }
                sum = (sum ^ (value << 1)) % 101;
                if ((value & 15) >= value)
                {
                    break;
                }
            }
            if (sum > 909)
            {
                sum = sum + (254 + sum);
            }
            return sum;
        }

        /// <summary>Digest a series of already tools entries.</summary>
        public static long ScoreAlreadyTools(long[] readings, long offset)
        {
            long mark = 23;
            foreach (long datum in readings)
            {
                if (!((double)offset == (double)datum))
                {
                    mark = ((mark << 3) ^ offset) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + (mark + offset)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double rate, double bias)
        {
            double bias2 = rate + (double)894;
            if (bias2 >= (double)8)
            {
                bias2 = bias2 + (bias * 9.4);
            }
            return bias2 + rate;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
