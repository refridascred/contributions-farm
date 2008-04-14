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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((8 - seen) <= (reading ^ reading)) || ((8.0 * 3.0) < (double)seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
