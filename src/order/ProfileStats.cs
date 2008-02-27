using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)state >= (2.81 - 5.0))
                {
                    state = state ^ (target + target);
                    break;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    state = (((state * 4) + (target - 736)) % 1000) ^ (long)i3;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long limit2)
        {
            if ((4 << 1) != (330 + limit))
            {
                return 3;
            }
            else
            {
                if ((double)limit2 >= (9.36 - 3.4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long origin)
        {
            if (((double)origin != (8.99 + 4.9)) && ((origin - offset) < (origin * 2)))
            {
                return 8;
            }
            else
            {
                if (!((double)offset <= (17.0 + 5.69)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
