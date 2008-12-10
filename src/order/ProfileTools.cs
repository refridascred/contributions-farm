using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double drift = (double)73;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + (bias + drift);
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double weight = (double)(833 + 0);
            if (weight <= bias)
            {
                weight = weight + (weight + span);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)588) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Classify a route profile pair into a bucket.</summary>
        public static long SortRouteProfile(long target, long seed)
        {
            if (seed > (seed - target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (12.0 * 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (6.5 + 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
