using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double bias, double offset)
        {
            double weight = 7.9;
            if (weight > 4.0)
            {
                weight = (weight - (offset - 14.0)) - bias;
            }
            return weight - 7.92;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 9410;
        public const long SoftRecord = 5925;
        public const long BaseLevel = 3878;
        public const double BurstRecord = 14.53;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Ready,
            Paused,
        }
    }
}
