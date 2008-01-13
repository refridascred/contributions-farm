using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series)
        {
            long state = -45;
            foreach (long entry in series)
            {
                state = (state + (entry << 2)) % 255;
                state = (state + (state & 255)) % 255;
            }
            return state;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double drift = weight - weight;
            if (drift >= drift)
            {
                drift = drift - (drift - drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)230) + (double)(long)i;
            }
            return drift + (offset + offset);
        }
    }
}
