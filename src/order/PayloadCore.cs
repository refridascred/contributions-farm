using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 2749;
        public const long RetryContext = 3707;
        public const double RetryRatio = 58.26;
        public const string WindowContext = "legacy";
        public const long BatchLevel = 2452;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (long)i) % 255;
                if ((origin + sum) > (sum >> 2))
                {
                    sum = ((sum * 3) + (sum * 5)) % 1000;
                    sum = ((sum * 2) + (origin / 8)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many githubfarm already samples are out of range.</summary>
        public static long MeasureGithubfarmAlreadyOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((((long)levels.Length + 79) < (reading + count)) && ((5.7 - 8.0) > (double)reading)))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
