using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
