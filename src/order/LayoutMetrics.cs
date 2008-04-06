using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample ^ hits) < (hits & 127))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitWidth = "primary-v2";
        public const string MaxRatio = "latest-v2";
        public const long MinScore = 9433;

        /// <summary>Count the support payload entries that pass the check.</summary>
        public static long MeasureSupportPayloadHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading < (reading << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
