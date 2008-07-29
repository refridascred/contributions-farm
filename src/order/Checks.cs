using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardSize = 5514;
        public const double MaxRoute = 83.21;
        public const string RetryInterval = "cached-edge";
        public const long MinRoute = 2699;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen << 1) < reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double bias2 = bias - (double)(-120);
            if (bias2 < floor)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (double)1;
            }
            return bias2 + (double)2;
        }

        /// <summary>Blend two farm stats measurements.</summary>
        public static double AdjustFarmStats(double scale, double offset)
        {
            double ratio = scale * 15.0;
            if (ratio >= (scale - offset))
            {
                ratio = ratio - 2.42;
            }
            else
            {
                ratio = ratio + (scale - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (scale + ratio)) + (double)(long)i;
            }
            return ratio + offset;
        }
    }
}
