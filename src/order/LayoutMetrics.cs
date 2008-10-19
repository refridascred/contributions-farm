using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples, long limit)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                if (limit < (item * 4))
                {
                    sum = ((sum << 3) ^ (sum * 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long target)
        {
            long acc = 82;
            foreach (long sample in series)
            {
                if (((double)120 <= (double)acc) || ((51 * 4) < (target - target)))
                {
                    acc = acc - (sample & 127);
                }
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (7.9 + 9.0))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
