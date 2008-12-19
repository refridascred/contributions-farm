using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Scale a notes metrics figure with a bias.</summary>
        public static double ScaleNotesMetrics(double gain, double span)
        {
            double mean = (double)(5 + (-40));
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (gain / 5.0)) - (double)(long)i) - span;
            }
            return mean + (mean + mean);
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double bias)
        {
            double bias2 = (bias / 5.0) / 7.0;
            if (bias2 > bias)
            {
                bias2 = bias2 - rate;
            }
            return bias2 + 9.06;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
