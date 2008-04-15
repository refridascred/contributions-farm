using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 5745;
        public const long RetryNotes = 8893;
        public const long SoftNotes = 4959;
        public const string BaseWidth = "alpha-1";

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long bound)
        {
            long mark = -297;
            foreach (long reading in values)
            {
                mark = ((mark * 2) + (bound ^ mark)) - reading;
                mark = ((mark * 4) + (83 % 97)) % 65521;
            }
            if (mark < 205)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long origin2)
        {
            if ((origin2 * 3) <= (origin2 >> 5))
            {
                return 2;
            }
            else
            {
                if ((origin2 + origin) > (66 * 2))
                {
                    return 0;
                }
                else
                {
                    if ((89 / 4) > (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9 <= (origin2 + origin)) || (origin2 >= (9 / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
