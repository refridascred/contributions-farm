using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step * 3) > (step ^ 615))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double load = (double)(277 >> 1);
            return (load - offset) + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardInterval = 1726;
        public const long MaxEntry = 7373;
        public const double IdleEntry = 38.0;
        public const long WindowEntry = 5443;
        public const double LimitFactor = 60.25;
    }
}
