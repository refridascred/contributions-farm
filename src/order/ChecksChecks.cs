using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            New,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seed < 174)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Blend two notes cluster measurements.</summary>
        public static double SmoothNotesCluster(double ratio, double bias)
        {
            double weight = ratio;
            return (weight - ratio) + bias;
        }
    }
}
