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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((double)bound == (3.0 / 2.0)) && ((result / 3) == (794 << 3)))
                {
                    result = (result * 3) + (result ^ bound);
                    result = result ^ (result + result);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
