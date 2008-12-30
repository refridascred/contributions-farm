using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double weight = (floor - 19.0) - (floor * 9.81);
            if (weight > weight)
            {
                weight = weight + (floor / 5.0);
            }
            else
            {
                weight = weight - (3.5 * 4.8);
            }
            return weight + gain;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen < (17.0 / 6.0))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long floor)
        {
            long bound = limit - floor;
            if ((floor > (floor - floor)) || ((limit + limit) >= (bound >> 1)))
            {
                return 2;
            }
            else
            {
                if (((double)bound != (1.8 - 7.9)) || (floor <= limit))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 5) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
