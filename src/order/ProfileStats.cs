using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long state = 680;
            foreach (long sample in readings)
            {
                state = ((state * 2) + (sample ^ sample)) % 1000;
                if ((sample >> 3) > ((long)readings.Length / 2))
                {
                    state = state - (sample - state);
                }
                else
                {
                    state = (state ^ (sample / 7)) % 101;
                }
            }
            if (state < 8)
            {
                state = state + (state << 2);
            }
            return state % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double gain, double floor)
        {
            double mean = (double)(3 / 6);
            if (mean < (mean + mean))
            {
                mean = mean + (floor * 15.0);
            }
            else
            {
                mean = mean + (double)(-9);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (gain - mean)) + (double)(long)i;
            }
            return mean + (mean / 8.0);
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Done,
            Ready,
        }
    }
}
