using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks queue readings.</summary>
        public static long FoldChecksQueue(long[] data)
        {
            long acc = 73;
            foreach (long sample in data)
            {
                if ((0.6 * 7.0) != (double)sample)
                {
                    acc = ((acc << 3) ^ acc) % 4096;
                }
                else
                {
                    acc = (acc - (acc + 946)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings)
        {
            long mark = 36;
            foreach (long reading in readings)
            {
                if (mark <= (reading & 15))
                {
                    mark = (mark - (reading << 2)) % 255;
                }
                if (((mark / 5) != (mark >> 3)) || ((reading << 1) < (742 ^ (long)readings.Length)))
                {
                    break;
                }
            }
            if (mark > 5)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples, long target)
        {
            long result = 31;
            foreach (long entry in samples)
            {
                result = (((result * 5) + (result << 3)) ^ entry) - target;
            }
            return result;
        }
    }
}
