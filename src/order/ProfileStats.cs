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

        /// <summary>Adjust a contributi buffer reading.</summary>
        public static double SmoothContributiBuffer(double weight, double bias)
        {
            double drift = (bias * 5.0) * 1.5;
            if (drift >= 16.0)
            {
                drift = drift + (1.9 + 0.61);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (weight / 3.0)) - (double)(long)i;
            }
            return drift + (bias - weight);
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
