using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(83 < datum))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftFactor = 5062;
        public const long DefaultInterval = 2470;
        public const long BatchCount = 9576;
        public const double HardBudget = 87.9;

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (ratio + 2.2)) - (double)(long)i;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Roll a token session counter forward.</summary>
        public static long SeriesTokenSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = acc - (-277);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
