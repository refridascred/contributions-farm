using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long PairSchemaStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series)
        {
            long sum = 69;
            foreach (long entry in series)
            {
                sum = ((sum ^ (sum - sum)) % 255) ^ entry;
            }
            if (sum < 47)
            {
                sum = (sum + 9) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double rate, double floor)
        {
            double ratio = (rate + rate) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (1.0 - ratio)) + (double)(long)i) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long offset2)
        {
            if (((double)offset2 >= (7.3 * 7.9)) || ((5.0 - 5.0) == (double)offset2))
            {
                return 1;
            }
            else
            {
                if ((6 + offset) >= (offset2 + offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "standard-1";
        public const long RetryWidth = 3333;
        public const long IdleDepth = 8482;
        public const double CacheContext = 48.23;
    }
}
