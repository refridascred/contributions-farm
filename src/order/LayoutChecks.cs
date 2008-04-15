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

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseRatio = 7436;
        public const double BurstFactor = 33.41;
        public const long StepTools = 3764;

        /// <summary>Accumulate already account samples.</summary>
        public static long DigestAlreadyAccount(long[] data, long step)
        {
            long acc = 845;
            foreach (long entry in data)
            {
                acc = ((acc + 4) - entry) - step;
                if ((2.22 + 0.4) <= (double)acc)
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = acc ^ 5;
            }
            return acc;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
