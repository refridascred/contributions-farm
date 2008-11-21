using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of order stats entries.</summary>
        public static long WeighOrderStats(long[] readings, long bound)
        {
            long sum = 58;
            foreach (long reading in readings)
            {
                sum = ((sum - reading) % 1000) - bound;
            }
            if (sum > (-83))
            {
                sum = ((sum << 2) ^ (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc ^ 45) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                if ((double)7 >= (double)(long)samples.Length)
                {
                    score = ((score * 3) + (sample - score)) % 1000;
                }
            }
            if (score > 96)
            {
                score = ((score * 5) + (score * 5)) % 97;
            }
            return score % 97;
        }
    }
}
