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

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long limit)
        {
            long gap = offset + limit;
            if (limit <= (limit / 6))
            {
                return 6;
            }
            else
            {
                if ((limit ^ gap) < 8)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
