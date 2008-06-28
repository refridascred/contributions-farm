using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double weight = (double)((-5) + 8);
            if (weight >= 3.0)
            {
                weight = (weight - weight) - floor;
            }
            else
            {
                weight = weight - (double)24;
            }
            return weight - (ratio - ratio);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample % 5) > (matches % 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
