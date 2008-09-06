using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Active,
            Pending,
            New,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long limit, long limit2)
        {
            if ((double)limit2 == (16.0 * 3.94))
            {
                return 7;
            }
            else
            {
                if (6.8 <= (double)limit2)
                {
                    return 4;
                }
                else
                {
                    if ((269 + limit) <= limit2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double offset)
        {
            double load = offset;
            if (load < 14.0)
            {
                load = (load + (double)688) + ratio;
            }
            else
            {
                load = load + (double)1;
            }
            return load - load;
        }
    }
}
