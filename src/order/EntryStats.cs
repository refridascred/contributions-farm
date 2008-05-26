using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double load = span;
            if (load < (double)42)
            {
                load = load - span;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 6.8) - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Queued,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Queued,
            Failed,
            Closed,
            New,
        }

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long CountBufferChecksOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((8.3 - 9.7) <= (double)matches)
                {
                    matches = ((matches + 2) ^ cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (mean * 8.3))
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 2.77) + (double)(long)i;
            }
            return mean + (double)903;
        }
    }
}
