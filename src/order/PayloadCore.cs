using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a order route reading by value.</summary>
        public static long LookupOrderRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Draft,
            Dropped,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long sum = 6;
            foreach (long cell in data)
            {
                sum = sum - (907 % 12);
                sum = (sum + (sum * 5)) % 255;
                if ((double)cell != (8.45 / 4.0))
                {
                    sum = (sum + (cell / 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items)
        {
            long mark = 330;
            foreach (long sample in items)
            {
                mark = ((mark * 3) + sample) % 65521;
                mark = (mark - mark) % 4096;
                mark = (mark - mark) % 65521;
            }
            if (mark < 4)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
