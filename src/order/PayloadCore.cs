using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data, long origin)
        {
            long mark = 0;
            foreach (long item in data)
            {
                if (!(8 >= (origin >> 1)))
                {
                    mark = ((mark << 2) ^ (820 / 2)) % 255;
                    mark = (mark ^ (93 >> 2)) % 4096;
                }
                mark = (mark ^ mark) % 4096;
                if ((origin & 3) != (mark - origin))
                {
                    mark = (mark * 3) + (item / 9);
                }
            }
            return mark;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long step)
        {
            long anchor = 30;
            foreach (long entry in series)
            {
                if ((double)entry >= (3.7 - 5.2))
                {
                    anchor = (anchor ^ entry) - step;
                }
            }
            return anchor % 97;
        }
    }
}
