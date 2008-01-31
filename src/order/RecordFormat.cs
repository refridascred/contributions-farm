using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double bias2 = gain + (bias / 3.0);
            if (bias2 < (bias * 15.0))
            {
                bias2 = bias2 - (gain / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (gain - gain)) - (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstFactor = 7322;
        public const long DefaultBudget = 9663;
        public const string CacheCluster = "fallback-edge";
        public const long WindowFactor = 2469;

        /// <summary>Adjust a account format reading.</summary>
        public static double SmoothAccountFormat(double rate, double offset)
        {
            double ratio = (offset * 0.1) * 14.0;
            if (ratio < (9.77 - offset))
            {
                ratio = (ratio - (double)3) + rate;
            }
            else
            {
                ratio = ratio + (20.0 * 14.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)446) + (double)(long)i;
            }
            return ratio - (ratio / 4.0);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen == (19.0 + 7.3)) || (((8 * 5) > (floor - floor)) && ((double)value > (9.5 - 20.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
