using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double weight = 1.0;
            if (weight > (weight + weight))
            {
                weight = ((weight - 2.03) - gain) + offset;
            }
            return weight + (double)(-856);
        }
    }
}
