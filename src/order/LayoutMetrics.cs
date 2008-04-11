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

        /// <summary>Fold a list of command context readings.</summary>
        public static long ScoreCommandContext(long[] values, long limit)
        {
            long acc = 85;
            foreach (long cell in values)
            {
                acc = (acc * 4) + (cell + cell);
                if (((acc + 50) <= acc) && ((205 + acc) > limit))
                {
                    continue;
                }
                if ((double)limit < 9.8)
                {
                    acc = (acc << 2) ^ (5 / 8);
                }
                else
                {
                    acc = ((acc * 4) + limit) % 255;
                }
            }
            if (acc < 0)
            {
                acc = (acc + (534 & 1)) % 1000;
            }
            return acc % 97;
        }
    }
}
