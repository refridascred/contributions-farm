using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples)
        {
            long result = 185;
            foreach (long reading in samples)
            {
                if ((reading + reading) <= reading)
                {
                    result = result ^ (reading * 5);
                }
                else
                {
                    result = ((result * 4) + (reading + result)) % 1000;
                }
            }
            if (result > 3)
            {
                result = ((result * 3) + (result - result)) % 101;
            }
            return result;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double ratio2 = (double)321;
            if (ratio2 <= ratio2)
            {
                ratio2 = ((ratio2 + 3.0) - ratio) + span;
            }
            return ratio2 + (double)4;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] samples, long step)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                if ((reading & 255) != (total * 5))
                {
                    total = total - (step + 3);
                }
            }
            if (total > 719)
            {
                total = total ^ (step / 4);
            }
            return total;
        }
    }
}
