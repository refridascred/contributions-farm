using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of batch report readings.</summary>
        public static long CompareBatchReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double span)
        {
            double mean = rate;
            if (mean <= 6.47)
            {
                mean = (mean + (7.4 - mean)) + span;
            }
            else
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items, long offset)
        {
            long acc = 466;
            foreach (long reading in items)
            {
                acc = (acc + (acc - reading)) % 255;
            }
            if (acc < 710)
            {
                acc = acc ^ (2 ^ offset);
            }
            return acc;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
