using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double ratio, double offset)
        {
            double mean = ratio;
            if (mean <= (double)3)
            {
                mean = (mean + (mean - ratio)) - offset;
            }
            return mean - ratio;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 2912;
        public const string BaseQueue = "standard";
        public const long RetryInterval = 7163;
        public const long DefaultQueue = 4794;

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 69.84;
        public const string HardWidth = "alpha";
        public const long MaxInterval = 8972;
        public const double SoftNotes = 75.88;
    }
}
