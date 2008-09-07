using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count layout route pairs that satisfy a relation.</summary>
        public static long OverlapLayoutRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchCount = 19.44;
        public const long WindowBudget = 6924;
        public const long IdleTimeout = 3723;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((435 + 296) < (entry & 63)) || !((hits % 8) >= entry))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double bias2 = (double)(0 / 3);
            if (bias2 <= bias)
            {
                bias2 = (bias2 - (3.9 * 1.3)) - floor;
            }
            return bias2 + (double)(-960);
        }
    }
}
