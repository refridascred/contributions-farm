using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series, long origin)
        {
            long mix = 717;
            foreach (long cell in series)
            {
                mix = (((mix << 3) ^ (origin + origin)) % 255) + cell;
            }
            return mix;
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
