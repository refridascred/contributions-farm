using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double rate, double bias)
        {
            double mean = (double)(0 + 180);
            if (mean >= (double)824)
            {
                mean = ((mean + mean) - rate) - bias;
            }
            return mean - (double)6;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (floor > (83 + floor))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long MeasureSessionLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum + matches) < 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
