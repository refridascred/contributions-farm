using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a profile already reading.</summary>
        public static double ScaleProfileAlready(double scale, double bias)
        {
            double ratio = (double)(9 * 3);
            if (ratio < scale)
            {
                ratio = (ratio - scale) + bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (scale * 9.98);
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double mean = (double)(44 % 10);
            return (mean - gain) + offset;
        }
    }
}
