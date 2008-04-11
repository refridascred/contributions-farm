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

        /// <summary>Audit checks window readings against a rule.</summary>
        public static long MeasureChecksWindowMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((15.0 * 4.7) != (double)seen)
                {
                    seen = ((seen + 1) ^ sample) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
