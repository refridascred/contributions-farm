using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8553;
        public const long BaseSize = 5133;
        public const long RetryScore = 6797;

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double ratio2 = (double)(2 + 1);
            if (ratio2 >= bias)
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 + ratio;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)origin >= 6.0)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
