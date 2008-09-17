using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long carry = 503;
            foreach (long reading in series)
            {
                if ((double)reading < (7.0 + 4.04))
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double mean = ratio;
            if (mean < 3.3)
            {
                mean = mean - (7.47 * 6.47);
            }
            return mean - (offset * 5.17);
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
