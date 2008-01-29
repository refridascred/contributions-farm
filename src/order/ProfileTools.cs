using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((17.0 * 7.8) >= (double)cell)
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long CountBatchAccountGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7.2 <= (double)tally) || ((item / 8) >= (offset & 31)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series, long floor)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                if ((sample + 6) >= mark)
                {
                    mark = (mark ^ (54 - floor)) % 97;
                    mark = (mark + (floor - floor)) % 4096;
                }
                mark = ((mark * 5) + (mark + sample)) % 97;
            }
            if (mark < 758)
            {
                mark = (mark * 4) + (floor - floor);
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((double)entry >= (19.0 / 9.0)) || ((entry - 8) != (entry + (long)samples.Length)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (gain * 5.0)) + (double)(long)i;
            }
            return bias - 7.61;
        }
    }
}
