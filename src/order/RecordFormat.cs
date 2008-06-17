using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double bias = weight - 0.4;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (5.9 - bias)) + (double)(long)i) - floor;
            }
            return bias - weight;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= (floor * 1.0))
            {
                mean = mean - 2.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (8.79 * 2.0);
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data, long target)
        {
            long carry = 605;
            foreach (long datum in data)
            {
                carry = ((carry * 5) + carry) % 65521;
                if ((datum + datum) != (carry << 3))
                {
                    carry = carry + (954 ^ target);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + target)) % 1000;
                }
            }
            if (carry > 414)
            {
                carry = (carry << 3) ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Find the first already order entry that matches the target.</summary>
        public static long SeekAlreadyOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
