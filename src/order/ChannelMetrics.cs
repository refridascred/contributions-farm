using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                if ((double)sum == (13.0 - 7.8))
                {
                    break;
                }
                if (sum >= (sum + sum))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSpan = 2051;
        public const long BatchChannel = 3233;
        public const double BaseLevel = 24.48;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double floor)
        {
            double load = (double)(8 + 4);
            if (load >= bias)
            {
                load = load + (floor * 1.57);
            }
            else
            {
                load = load - load;
            }
            return load - (load * 17.0);
        }
    }
}
