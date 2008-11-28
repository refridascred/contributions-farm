using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double load = scale;
            if (load < (3.61 - bias))
            {
                load = load - (double)625;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load / 9.0)) + (double)(long)i;
            }
            return load - (bias * 8.54);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples)
        {
            long anchor = 50;
            foreach (long item in samples)
            {
                if (item < anchor)
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor > 61)
            {
                anchor = (anchor - (4 + anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            Active,
            New,
            Stale,
            Locked,
        }
    }
}
