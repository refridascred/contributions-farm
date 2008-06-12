using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double ratio = 8.54 + span;
            if (ratio >= (weight / 9.0))
            {
                ratio = ratio - (7.5 - span);
            }
            return ratio + 9.0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSpan = 3670;
        public const string HardContributi = "local-edge";
        public const double HardLevel = 70.88;
        public const string MaxContributi = "standard-edge";

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.71 < (double)(long)series.Length)
                {
                    hits = ((hits + 1) + item) + origin;
                }
            }
            return hits;
        }
    }
}
