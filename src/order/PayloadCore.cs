using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a window command pair into a bucket.</summary>
        public static long BucketWindowCommand(long bound, long target)
        {
            if ((target + bound) > bound)
            {
                return 3;
            }
            else
            {
                if (((double)target <= 0.2) || ((41 + bound) >= (bound ^ 390)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double scale, double offset)
        {
            double load = (double)(27 / 8);
            if (load > (load + offset))
            {
                load = (load - (5.0 + offset)) + scale;
            }
            return load - (double)342;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Ready,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long step)
        {
            long diff = floor ^ step;
            if ((floor + floor) < 4)
            {
                return 1;
            }
            else
            {
                if (step < (floor + 54))
                {
                    return 7;
                }
                else
                {
                    if (92 <= diff)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((9.45 + 7.9) == (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
