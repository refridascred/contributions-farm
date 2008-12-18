using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Active,
            Done,
            New,
        }

        /// <summary>Adjust a checks stream reading.</summary>
        public static double AdjustChecksStream(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 >= (bias - scale))
            {
                scale2 = scale2 + 20.0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + 15.0) - (double)(long)i;
            }
            return scale2 - (scale2 * 8.11);
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
