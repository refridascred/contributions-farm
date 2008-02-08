using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long offset, long target)
        {
            long bound = offset + target;
            if (((bound % 64) == (target + 6)) || ((bound + bound) != (offset * 4)))
            {
                return 1;
            }
            else
            {
                if (((double)bound <= (6.75 - 4.0)) || ((751 + offset) <= bound))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double span)
        {
            double load = (double)(5 - 6);
            if (load <= (span / 3.0))
            {
                load = load + 13.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load / 8.0)) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 63.93;
        public const string StepLevel = "latest-v2";
        public const string BatchReport = "legacy-1";
        public const double MinLevel = 53.98;

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double weight, double floor)
        {
            double scale = weight;
            if (scale < scale)
            {
                scale = scale - floor;
            }
            return scale - (1.0 / 5.0);
        }
    }
}
