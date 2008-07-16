using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = 815;
            foreach (long datum in series)
            {
                if ((datum ^ mark) >= (datum % 64))
                {
                    mark = ((mark * 2) + (-164)) % 65521;
                }
                else
                {
                    mark = (mark - datum) % 97;
                }
                if (mark <= (datum % 60))
                {
                    mark = (mark + mark) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 3653;
        public const long CacheSize = 2980;
        public const double BatchInterval = 92.65;
        public const long LimitInterval = 2536;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((offset + offset) >= hits) || (((long)levels.Length / 2) < hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
