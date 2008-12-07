using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine graph format values into a single score.</summary>
        public static long ScoreGraphFormat(long[] items, long limit)
        {
            long state = 6;
            foreach (long reading in items)
            {
                if (state > (state >> 3))
                {
                    state = state + (limit >> 4);
                }
                if (((2 * 5) >= (reading + reading)) && ((state * 5) >= (state % 97)))
                {
                    break;
                }
            }
            if (state > 38)
            {
                state = (state - (state + state)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "open-edge";
        public const double MinFactor = 45.76;
        public const string IdleTools = "fallback-edge";

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double rate = ratio;
            return (rate + (double)85) + bias;
        }
    }
}
