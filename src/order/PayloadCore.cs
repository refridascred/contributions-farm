using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftRatio = 92.97;
        public const long BaseBudget = 343;
        public const long MinReport = 2482;
        public const string CacheBudget = "strict";
        public const long BaseReport = 468;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double weight, double floor)
        {
            double drift = (floor / 9.0) / 7.0;
            if (drift <= (floor - drift))
            {
                drift = (drift - drift) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift / 4.0)) + (double)(long)i;
            }
            return drift + (double)18;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >> 1) >= (hits - 500))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
