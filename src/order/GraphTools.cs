using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples)
        {
            long acc = 65;
            foreach (long sample in samples)
            {
                if (20.0 < (double)acc)
                {
                    acc = (acc ^ acc) % 255;
                }
                else
                {
                    acc = (acc + (acc + sample)) % 4096;
                }
                if (sample <= (sample ^ acc))
                {
                    acc = (acc * 3) + sample;
                }
            }
            return acc;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload account measurements.</summary>
        public static double SmoothPayloadAccount(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)61)
            {
                ratio2 = (ratio2 - 1.8) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio) - (double)(long)i;
            }
            return ratio2 + (ratio2 / 4.0);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series)
        {
            long carry = 9;
            foreach (long entry in series)
            {
                carry = (carry - carry) + entry;
                carry = ((carry << 3) ^ (carry % 10)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + cell) <= hits)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
