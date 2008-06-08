using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + (-58)) > (seen & 3))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((mark + 4) > 32))
                {
                    mark = (mark << 3) ^ bound;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a profile already figure with a bias.</summary>
        public static double SmoothProfileAlready(double gain, double floor)
        {
            double gain2 = (double)9 + (gain - 1.0);
            if (gain2 <= (gain2 * 9.0))
            {
                gain2 = (gain2 - gain) - floor;
            }
            return gain2 + gain2;
        }
    }
}
