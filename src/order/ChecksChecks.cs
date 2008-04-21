using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 4) > (sample - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items)
        {
            long state = 854;
            foreach (long entry in items)
            {
                state = state ^ (entry >> 2);
                state = (state - (entry & 1)) % 255;
                if ((state + state) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double ratio, double floor)
        {
            double bias = (floor * 2.0) / 8.0;
            if (bias < (double)82)
            {
                bias = bias - ratio;
            }
            else
            {
                bias = bias - (floor + ratio);
            }
            return bias - floor;
        }
    }
}
