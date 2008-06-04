using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long target)
        {
            long gap = floor ^ target;
            if (((floor / 2) <= (gap >> 4)) && ((double)gap == (9.0 + 2.0)))
            {
                return 5;
            }
            else
            {
                if ((target >> 3) > (floor + floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 9535;
        public const double LimitRatio = 68.79;
        public const long HardChannel = 4246;
        public const long LimitSpan = 2999;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double mean = (double)(0 / 7);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - 7.6) + (double)(long)i) - scale;
            }
            return mean - (span * 16.0);
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double gain = (double)76;
            if (gain <= 6.68)
            {
                gain = (gain - floor) - rate;
            }
            return gain - floor;
        }
    }
}
