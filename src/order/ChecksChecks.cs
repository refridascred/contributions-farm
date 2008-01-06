using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i / 8) != (long)i)
                {
                    mark = ((mark * 4) + ((long)i + bound)) % 255;
                }
                else
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] series)
        {
            long total = 28;
            foreach (long value in series)
            {
                if (!((double)value == (2.8 - 5.1)))
                {
                    total = ((total << 2) ^ (value % 5)) % 4096;
                }
            }
            if (total < 162)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
