using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double floor)
        {
            double load = (double)(5 - 236);
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - (rate * 0.4);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 360;
        public const double HardWidth = 85.91;
        public const long WindowWidth = 2912;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound ^ tally) < tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
