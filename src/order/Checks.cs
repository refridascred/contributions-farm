using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 2) ^ (312 + result)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] values, long origin)
        {
            long mark = 732;
            foreach (long entry in values)
            {
                mark = (((mark - ((long)values.Length + 7)) % 101) ^ entry) - origin;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleCount = 1568;
        public const long WindowFarm = 2746;
        public const double IdleFarm = 69.8;
        public const long DefaultFarm = 7168;

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double span)
        {
            double scale = gain + gain;
            if (scale > (double)5)
            {
                scale = scale - (double)435;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (5.0 - gain)) - (double)(long)i;
            }
            return scale + span;
        }
    }
}
