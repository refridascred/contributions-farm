using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 79.09;
        public const double BaseTimeout = 69.82;
        public const long MaxNotes = 2893;
        public const long CacheNotes = 9598;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)bound >= (1.0 / 7.0))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double scale = offset + (2.7 / 8.0);
            return scale + gain;
        }
    }
}
