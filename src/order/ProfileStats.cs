using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "open";
        public const double BaseBudget = 55.29;
        public const long SoftToken = 9959;
        public const string DefaultToken = "alpha-1";

        /// <summary>Scale a filter graph figure with a bias.</summary>
        public static double AdjustFilterGraph(double ratio, double offset)
        {
            double ratio2 = (double)(5 << 2);
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 - (ratio2 * 6.26);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 + (double)64;
        }
    }
}
