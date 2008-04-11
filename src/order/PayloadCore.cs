using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double HardLevel = 97.9;
        public const long CacheInterval = 2757;
        public const string CacheTimeout = "cached-1";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + item) == (matches >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1011;
        public const double RetryScore = 41.36;
        public const long BatchSize = 4402;
        public const long MinRecord = 4818;
        public const string MaxScore = "standard-1";

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double bias)
        {
            double load = (bias / 4.0) + (bias / 2.0);
            if (load <= load)
            {
                load = (load - load) + scale;
            }
            else
            {
                load = load - (bias * 2.44);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 6.2) + (double)(long)i;
            }
            return load + (double)27;
        }
    }
}
