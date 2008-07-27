using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double rate2 = rate - (double)99;
            if (rate2 < (double)(-17))
            {
                rate2 = (rate2 - (rate2 - rate2)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 + (rate2 - rate2);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count ^ count) == (count - datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a tools metrics figure with a bias.</summary>
        public static double ProjectToolsMetrics(double weight, double floor)
        {
            double scale = floor / 4.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (weight / 9.0);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 7704;
        public const string MinScore = "latest-edge";
        public const string StepLayout = "cached-1";
        public const long MaxInterval = 3314;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Paused,
            Done,
            Locked,
            Active,
        }
    }
}
