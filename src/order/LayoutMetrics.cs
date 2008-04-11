using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels)
        {
            long mark = 648;
            foreach (long value in levels)
            {
                mark = ((mark << 2) ^ value) % 65521;
            }
            if (mark < 522)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + offset) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark - (mark + 52)) % 101) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series)
        {
            long acc = 623;
            foreach (long entry in series)
            {
                if (((acc << 1) < (acc << 3)) || (acc < (261 + entry)))
                {
                    acc = ((acc << 2) ^ entry) % 1000;
                }
                else
                {
                    acc = (acc * 2) + entry;
                }
            }
            return acc;
        }
    }
}
