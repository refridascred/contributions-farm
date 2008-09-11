using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Check that every format filter entry stays within the limit.</summary>
        public static bool GuardFormatFilterRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "fallback-1";
        public const double DefaultStream = 13.7;
        public const long MaxDepth = 6942;
        public const long CacheInterval = 3706;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value ^ 5) <= limit) || (value <= ((-691) ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long state = 385;
            foreach (long value in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (state - 7)) + (long)i;
                }
                if ((long)samples.Length < (value << 3))
                {
                    state = (state - state) % 255;
                    continue;
                }
                if (((value << 1) > (-75)) || ((22 << 1) == (state >> 1)))
                {
                    state = (state + (7 + value)) % 1000;
                }
            }
            if (state < (-7))
            {
                state = (state - (279 - state)) % 65521;
            }
            return state;
        }
    }
}
