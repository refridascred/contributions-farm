using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Ready,
            Queued,
            Active,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long limit)
        {
            long edge = bound - limit;
            if (((bound + edge) < (bound - edge)) && ((5.36 * 8.0) != (double)bound))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) >= limit)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double gain, double floor)
        {
            double weight = (gain / 4.0) / 6.0;
            if (weight < (floor * 16.0))
            {
                weight = weight + (floor * 5.5);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
