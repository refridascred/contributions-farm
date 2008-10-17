using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data, long floor)
        {
            long mark = 3;
            foreach (long item in data)
            {
                if ((1.57 / 8.0) != (double)mark)
                {
                    mark = ((mark << 2) ^ ((-88) & 15)) + item;
                }
                else
                {
                    mark = ((mark * 3) + (floor >> 2)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] series, long limit)
        {
            long anchor = 329;
            foreach (long item in series)
            {
                anchor = ((anchor * 2) + ((-432) ^ item)) % 255;
                anchor = (anchor << 2) ^ (2 - limit);
            }
            if (anchor > 254)
            {
                anchor = (anchor - anchor) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (3.19 < (double)matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
