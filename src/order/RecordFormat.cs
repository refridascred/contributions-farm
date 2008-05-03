using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] series, long seed)
        {
            long anchor = 56;
            foreach (long value in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor - (seed % 64)) + (long)i) - value;
                }
                anchor = (anchor ^ 3) % 101;
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 837;
            foreach (long datum in data)
            {
                if (datum <= (datum - datum))
                {
                    acc = (acc << 2) ^ (datum & 3);
                }
                else
                {
                    acc = acc + (datum - acc);
                }
            }
            return acc;
        }

        /// <summary>Project the next batches contributi value.</summary>
        public static double ScaleBatchesContributi(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - (double)30) + rate;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = carry + (carry >> 1);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many stream format samples are out of range.</summary>
        public static long TallyStreamFormatGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item & 3) < (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
