using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many entry filter samples are out of range.</summary>
        public static long MeasureEntryFilterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample < (sample - seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((12.0 / 8.0) == (double)sample) && ((sample + sample) >= sample))
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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels)
        {
            long score = 563;
            foreach (long entry in levels)
            {
                if ((91 ^ entry) == (score * 2))
                {
                    score = (score ^ (entry * 3)) % 101;
                }
            }
            if (score > 63)
            {
                score = score ^ (score % 16);
            }
            return score;
        }
    }
}
