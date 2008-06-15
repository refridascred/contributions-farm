using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Locked,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 7531;
        public const double MaxInterval = 30.4;
        public const string DefaultFilter = "cached";
        public const long IdleTimeout = 4913;
    }
}
