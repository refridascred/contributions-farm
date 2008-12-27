using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels)
        {
            long mix = 289;
            foreach (long item in levels)
            {
                mix = (mix - (item % 3)) % 97;
            }
            return mix % 97;
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
