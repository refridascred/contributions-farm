using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long step, long seed)
        {
            long lane = step - seed;
            if ((step ^ seed) <= (lane + 80))
            {
                return 4;
            }
            else
            {
                if ((250 + lane) < (9 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((lane >= (seed + lane)) || ((seed ^ lane) <= lane))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
