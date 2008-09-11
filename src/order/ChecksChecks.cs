using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((63 * 3) > matches)
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double span)
        {
            double scale = span;
            if (scale < span)
            {
                scale = (scale + 1.26) + ratio;
            }
            else
            {
                scale = scale - (double)317;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)9) - (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Fold a list of context stream readings.</summary>
        public static long FoldContextStream(long[] levels)
        {
            long total = -2;
            foreach (long cell in levels)
            {
                total = (total * 3) + cell;
                total = total ^ (cell / 6);
            }
            if (total < 22)
            {
                total = total - (573 + total);
            }
            return total;
        }
    }
}
