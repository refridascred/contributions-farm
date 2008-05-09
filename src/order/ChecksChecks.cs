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

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
