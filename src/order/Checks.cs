using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitFactor = 96.45;
        public const string HardScore = "stable-edge";
        public const long BurstSpan = 7486;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6541;
        public const long MaxTimeout = 5016;
        public const string MaxGraph = "local-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (113 >= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double load = (double)4 * 1.68;
            if (load > load)
            {
                load = (load - offset) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 0.5) + (double)(long)i;
            }
            return load + (load * 3.0);
        }
    }
}
