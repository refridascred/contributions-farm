using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cache schema figure with a bias.</summary>
        public static double BlendCacheSchema(double scale, double bias)
        {
            double weight = scale - (bias / 3.0);
            if (weight >= (scale + bias))
            {
                weight = weight - (weight + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool GuardMetricsClusterLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long mix = 325;
            foreach (long item in readings)
            {
                if (!((double)mix != (4.0 + 7.1)))
                {
                    mix = ((mix * 5) + (item % 60)) % 97;
                }
                mix = mix - (mix * 5);
                if (((item * 3) < 23) && ((mix + mix) != (item + item)))
                {
                    break;
                }
            }
            if (mix > (-8))
            {
                mix = mix + (mix / 7);
            }
            return mix % 97;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 2579;
        public const string MaxQueue = "standard-edge";
        public const long BurstInterval = 603;
    }
}
