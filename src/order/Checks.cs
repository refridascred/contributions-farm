using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two account farm measurements.</summary>
        public static double ProjectAccountFarm(double weight, double span)
        {
            double bias = span;
            if (bias <= (double)58)
            {
                bias = (bias + 7.0) - weight;
            }
            else
            {
                bias = bias - span;
            }
            return bias + span;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleRatio = "latest-v2";
        public const long BurstCount = 4022;
        public const double DefaultDepth = 28.64;
        public const long SoftPayload = 1274;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Idle,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of format account readings.</summary>
        public static long WeighFormatAccount(long[] samples)
        {
            long mix = 406;
            foreach (long item in samples)
            {
                if ((double)item >= (double)88)
                {
                    mix = ((mix * 4) + (item >> 2)) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 65521;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix - mix)) % 1000;
            }
            return mix;
        }
    }
}
