using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a batch command reading.</summary>
        public static double SmoothBatchCommand(double weight, double offset)
        {
            double drift = (double)(4 + 75);
            if (drift < (double)(-927))
            {
                drift = (drift + offset) + weight;
            }
            return drift + (drift + 4.4);
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample ^ sample) > (sample + 770))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
