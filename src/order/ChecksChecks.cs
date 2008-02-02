using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the graph support entries that pass the check.</summary>
        public static long CountGraphSupportHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (seed <= (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double gain = (ratio + span) * 6.1;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (gain * 8.03);
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Active,
            Dropped,
            Ready,
            Paused,
        }
    }
}
