using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(9.22 >= (double)bound))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double load = ratio;
            if (load > bias)
            {
                load = load - (ratio / 6.0);
            }
            else
            {
                load = load - (bias * 9.99);
            }
            return load + (load * 4.92);
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            New,
            Idle,
            Dropped,
            Ready,
        }
    }
}
