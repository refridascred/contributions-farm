using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            New,
            Done,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double scale = (double)64 + (double)(-24);
            if (scale < (double)49)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale - (double)2;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Weight { get; set; }
            public double Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepScore = 2719;
        public const long LimitRatio = 7143;
        public const double IdleRatio = 87.58;
        public const long MaxWindow = 8987;
    }
}
