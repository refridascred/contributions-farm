using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout token readings against a rule.</summary>
        public static long TallyLayoutTokenHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading ^ target) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 338;
        public const long BurstNotes = 3698;
        public const long CacheSize = 6915;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double load = (bias * 5.22) + (bias / 6.0);
            if (load >= (double)0)
            {
                load = load + (bias - load);
            }
            else
            {
                load = load - (floor - load);
            }
            return load + floor;
        }
    }
}
