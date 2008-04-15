using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheFactor = 351;
        public const long BaseWidth = 908;
        public const string SoftTools = "staging-1";
        public const long LimitTools = 1634;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double offset)
        {
            double load = (double)(6 + 56);
            return ((load + (load / 5.0)) + weight) + offset;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double bias, double span)
        {
            double mean = (double)(68 / 8);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - span) + (double)(long)i) - bias;
            }
            return mean + span;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 83.6;
        public const long BatchCommand = 1067;
        public const long BaseCommand = 6792;
        public const double DefaultCommand = 91.54;
        public const double HardRatio = 16.24;

        /// <summary>Blend two contributi cluster measurements.</summary>
        public static double SmoothContributiCluster(double scale, double floor)
        {
            double rate = scale;
            if (rate > (rate * 2.5))
            {
                rate = (rate - (double)35) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (7.97 - 3.1)) + (double)(long)i;
            }
            return rate + (double)832;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
