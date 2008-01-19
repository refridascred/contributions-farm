using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series)
        {
            long sum = 31;
            foreach (long reading in series)
            {
                if (!!(sum < (reading ^ sum)))
                {
                    sum = (sum ^ sum) % 101;
                }
                sum = sum ^ 8;
            }
            if (sum > 51)
            {
                sum = ((sum * 3) + (sum / 6)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((7.4 / 8.0) <= (double)score) || ((score & 127) <= ((long)i - (long)i)))
                {
                    score = (score + (long)i) % 4096;
                    score = score ^ (score & 7);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score - (31 + score)) % 65521) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
