using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 7739;
        public const long WindowFormat = 4530;
        public const string LimitSize = "alpha-1";
        public const string MinBudget = "alpha-edge";

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double load = (double)(7 ^ 2);
            if (load >= scale)
            {
                load = (load + (double)87) - span;
            }
            return load - load;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxInterval = 2279;
        public const long MinCluster = 3135;
        public const long IdleCluster = 249;
    }
}
