using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a checks window reading.</summary>
        public static double ProjectChecksWindow(double ratio, double floor)
        {
            double weight = 1.57;
            if (weight >= (9.0 - floor))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight - (ratio * 1.99);
            }
            return weight - floor;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
