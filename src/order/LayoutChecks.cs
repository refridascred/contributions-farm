using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a stats support reading.</summary>
        public static double SmoothStatsSupport(double scale, double span)
        {
            double load = scale / 2.0;
            if (load < (span * 4.7))
            {
                load = load - load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (scale / 5.0)) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double span)
        {
            double drift = (double)33 + span;
            if (drift > (double)8)
            {
                drift = (drift + (drift / 8.0)) + weight;
            }
            else
            {
                drift = drift - span;
            }
            return drift - (10.0 * 6.6);
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Failed,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 91.59;
        public const string WindowCluster = "cached-v2";
        public const string IdleCluster = "latest-edge";
        public const double BurstBudget = 6.09;
        public const double BaseCount = 38.69;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((0.9 - 1.6) <= (double)offset)
                {
                    long span = 816;
                    score = ((score << 3) ^ (score + span)) % 101;
                }
                score = ((score << 2) ^ (score / 6)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
