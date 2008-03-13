using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of context farm readings.</summary>
        public static long PairContextFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double ratio = rate;
            if (ratio > (double)289)
            {
                ratio = (ratio + (double)8) - span;
            }
            return ratio + (rate / 3.0);
        }
    }
}
