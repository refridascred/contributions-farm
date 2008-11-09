using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = total + (long)i;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a queue stats figure with a bias.</summary>
        public static double BlendQueueStats(double weight, double floor)
        {
            double scale = weight + floor;
            return scale + scale;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Ready,
            Locked,
        }
    }
}
