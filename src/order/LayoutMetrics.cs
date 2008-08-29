using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double ratio, double bias)
        {
            double load = 6.3;
            if (load >= (load + load))
            {
                load = load - (12.0 / 8.0);
            }
            else
            {
                load = load - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (double)261;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((7.6 - 4.31) < (double)origin))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
