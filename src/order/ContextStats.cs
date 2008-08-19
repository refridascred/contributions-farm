using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double scale = (double)87 + (ratio / 2.0);
            return (scale - ratio) + floor;
        }

        /// <summary>Fold a list of token tools readings.</summary>
        public static long WeighTokenTools(long[] levels, long target)
        {
            long total = 8;
            foreach (long sample in levels)
            {
                total = (total + (target + total)) ^ sample;
            }
            return total;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long seed, long seed2)
        {
            if ((seed << 2) < (seed2 + seed))
            {
                return 8;
            }
            else
            {
                if (((double)seed2 < (double)seed) && (seed >= (seed >> 4)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
