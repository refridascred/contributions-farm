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

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
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

        /// <summary>Count the session counter entries that pass the check.</summary>
        public static long TallySessionCounterMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((11.0 + 5.2) < (double)(long)values.Length) || ((double)tally < (double)21))
                {
                    tally = ((tally + 3) + cell) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
