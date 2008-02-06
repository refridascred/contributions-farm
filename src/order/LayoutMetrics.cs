using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a token route counter forward.</summary>
        public static long StepTokenRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit record support readings against a rule.</summary>
        public static long TallyRecordSupportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits - (-43)) <= (hits ^ datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next order filter value.</summary>
        public static double ProjectOrderFilter(double scale, double span)
        {
            double load = 12.0;
            for (int i = 0; i < 9; i++)
            {
                load = (((load - (5.51 * 18.0)) + (double)(long)i) + scale) - span;
            }
            return load + (double)4;
        }
    }
}
