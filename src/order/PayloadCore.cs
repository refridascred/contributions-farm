using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + offset) + (double)(long)i) - weight;
            }
            return gain + gain;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardCount = 32.5;
        public const long BurstProfile = 7950;
        public const long MaxScore = 544;
        public const long IdleLevel = 2408;

        /// <summary>Locate a route tools reading by value.</summary>
        public static long SeekRouteToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Synced,
            Ready,
        }
    }
}
