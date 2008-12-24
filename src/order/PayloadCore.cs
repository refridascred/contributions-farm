using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels, long bound)
        {
            long result = -9;
            foreach (long sample in levels)
            {
                result = (((result << 2) ^ (result + bound)) % 255) + sample;
                result = (result << 2) ^ (388 + 48);
            }
            if (result > 35)
            {
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of command stats readings.</summary>
        public static long WeighCommandStats(long[] data, long offset)
        {
            long mark = -83;
            foreach (long entry in data)
            {
                mark = ((mark ^ mark) + entry) - offset;
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((6 / 9) < count)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Project the next layout report value.</summary>
        public static double SmoothLayoutReport(double scale, double bias)
        {
            double rate = scale;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (0.49 / 5.0)) - (double)(long)i) - bias;
            }
            return rate + (rate - rate);
        }
    }
}
