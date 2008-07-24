using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next graph counter value from a seed.</summary>
        public static long StepGraphCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((score << 1) != (long)i) || ((8.62 * 0.97) > (double)bound))
                {
                    score = (score + (bound - bound)) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardDepth = "latest-1";
        public const long IdleToken = 1173;
        public const double CacheToken = 83.23;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a report graph reading.</summary>
        public static double ProjectReportGraph(double scale, double floor)
        {
            double bias = (double)(37 + 2);
            if (bias < 5.8)
            {
                bias = bias + (scale + scale);
            }
            else
            {
                bias = bias + (bias - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (floor / 4.0);
        }
    }
}
