using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long seed)
        {
            if (((seed >> 4) < (792 % 60)) || ((target ^ seed) <= (645 + target)))
            {
                return 0;
            }
            else
            {
                if (seed >= (seed >> 2))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long target)
        {
            if (((target ^ target) > (target + seed)) || ((target ^ 539) >= ((-88) << 3)))
            {
                return 5;
            }
            else
            {
                if ((seed >= (seed << 1)) && ((target << 2) > (71 - seed)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a filter window figure with a bias.</summary>
        public static double ProjectFilterWindow(double gain, double floor)
        {
            double gain2 = gain / 2.0;
            if (gain2 < (gain2 / 7.0))
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 + (floor + floor);
            }
            return gain2 - (floor * 2.99);
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = total + (28 + (long)i);
                if (((long)i * 4) <= (limit + limit))
                {
                    total = total ^ (total & 3);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
