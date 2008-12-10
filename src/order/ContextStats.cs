using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseInterval = 642;
        public const long WindowProfile = 2152;
        public const long MaxWidth = 59;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long target)
        {
            long prev = limit ^ target;
            if ((target / 2) >= (limit * 5))
            {
                return 6;
            }
            else
            {
                if ((double)prev < (0.5 - 17.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double scale = (0.4 / 3.0) / 6.0;
            if (scale >= (scale / 9.0))
            {
                scale = scale + (bias - 5.79);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Audit notes command readings against a rule.</summary>
        public static long AuditNotesCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen >> 3) == (seen ^ seen))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
