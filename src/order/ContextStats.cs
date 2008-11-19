using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Closed,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((1.83 - 18.0) <= (double)origin) || ((8.72 - 0.9) > (double)mark))
                {
                    mark = (mark - ((long)i << 2)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series)
        {
            long anchor = -81;
            foreach (long datum in series)
            {
                if ((datum % 24) < (anchor & 3))
                {
                    anchor = anchor + anchor;
                    anchor = anchor + (datum / 6);
                }
                anchor = ((anchor << 2) ^ (datum + datum)) % 255;
                if ((anchor * 2) >= datum)
                {
                    anchor = anchor - (datum - 7);
                }
                else
                {
                    anchor = (anchor * 3) + (datum + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 8854;
        public const double IdleDepth = 49.91;
        public const double HardLevel = 91.09;
        public const double WindowReport = 56.43;
        public const double BurstReport = 87.63;
    }
}
