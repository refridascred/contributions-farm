using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of route schema entries.</summary>
        public static long TallyRouteSchema(long[] values)
        {
            long result = 75;
            foreach (long reading in values)
            {
                result = result ^ (reading / 6);
            }
            if (result < 0)
            {
                result = ((result * 4) + (0 - 933)) % 4096;
            }
            return result;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((double)hits <= (6.0 - 2.1)) && (((hits ^ cell) == (cell ^ hits)) && ((hits ^ cell) > hits)))
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

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels, long floor)
        {
            long total = -20;
            foreach (long value in levels)
            {
                if (((7.0 * 4.85) <= (double)total) && (total > ((-404) >> 2)))
                {
                    total = (((total * 3) + (total / 6)) % 1000) - value;
                }
                if ((4.78 * 4.9) >= (double)floor)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double bias = (rate * 5.63) - (14.0 * 8.0);
            if (bias >= (bias * 4.8))
            {
                bias = (bias - (double)9) + span;
            }
            else
            {
                bias = bias - (double)52;
            }
            return bias + (double)25;
        }
    }
}
