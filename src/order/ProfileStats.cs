using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long seed)
        {
            if (bound > (499 * 2))
            {
                return 6;
            }
            else
            {
                if ((1.65 / 6.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((6.0 * 20.0) <= (double)seed) && ((bound ^ seed) < (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound > (9 + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics route series from a seed.</summary>
        public static long RollMetricsRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((sum - sum) <= (limit * 3))
                {
                    sum = ((sum * 5) + limit) % 1000;
                }
                if ((876 + limit) != (limit - limit))
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
