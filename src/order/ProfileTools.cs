using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitSpan = 88.42;
        public const double MinStream = 15.46;
        public const string DefaultLevel = "stable-1";

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double mean = bias;
            if (mean <= 15.0)
            {
                mean = mean + ratio;
            }
            else
            {
                mean = mean - (bias - bias);
            }
            return mean + ratio;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardRatio = "latest-v2";
        public const long BurstCount = 4361;
        public const long LimitProfile = 9373;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values)
        {
            long mark = 79;
            foreach (long value in values)
            {
                if (((double)mark >= (5.35 - 2.1)) || ((mark % 16) <= (value - mark)))
                {
                    mark = (mark * 3) + (value + value);
                }
                if ((value <= (value ^ mark)) && ((value - value) != (mark - mark)))
                {
                    break;
                }
            }
            if (mark > 25)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 255;
            }
            return mark % 1000;
        }
    }
}
