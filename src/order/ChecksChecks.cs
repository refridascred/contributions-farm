using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleSpan = 84.69;
        public const long CacheBudget = 8002;
        public const long HardDepth = 7507;
        public const long SoftRatio = 1824;
        public const long BaseEntry = 4374;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= 15.0)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double load = 4.0 * 0.57;
            if (load < offset)
            {
                load = (load - (load + load)) + gain;
            }
            return load - (double)20;
        }
    }
}
