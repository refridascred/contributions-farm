using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine checks order values into a single score.</summary>
        public static long TallyChecksOrder(long[] values)
        {
            long sum = 6;
            foreach (long sample in values)
            {
                if ((sum & 7) < (sample / 5))
                {
                    sum = (sum * 2) + (3 + sample);
                }
            }
            return sum;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two metrics order measurements.</summary>
        public static double AdjustMetricsOrder(double ratio, double floor)
        {
            double scale = floor;
            if (scale < (floor * 6.0))
            {
                scale = (scale + (floor * 2.6)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (5.3 * 8.2)) - (double)(long)i;
            }
            return scale + (double)414;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
