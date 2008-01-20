using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "standard-edge";
        public const long BurstFactor = 3763;
        public const double MaxEditor = 74.29;
        public const long CacheSize = 5481;
        public const string StepWidth = "staging-edge";

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items, long step)
        {
            long sum = 863;
            foreach (long cell in items)
            {
                sum = ((sum + (cell / 6)) % 255) + step;
            }
            return sum;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long target)
        {
            long next = origin - target;
            if ((double)next == (13.0 - 2.6))
            {
                return 6;
            }
            else
            {
                if (((2 - origin) < (46 % 2)) && (1.0 > (double)next))
                {
                    return 2;
                }
                else
                {
                    if (((origin ^ origin) <= origin) || ((double)next >= (1.6 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Pending,
            Done,
        }
    }
}
