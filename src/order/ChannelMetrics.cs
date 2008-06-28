using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two batch report measurements.</summary>
        public static double AdjustBatchReport(double weight, double offset)
        {
            double load = (double)69 - weight;
            if (load > (weight * 7.0))
            {
                load = load - (17.0 + offset);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + (load + load);
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
