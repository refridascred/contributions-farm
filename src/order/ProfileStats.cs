using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double load = 12.0;
            return (load - scale) + span;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits > (double)285)
                {
                    hits = ((hits + 1) + reading) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Failed,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseRatio = 56.17;
        public const long BatchWidth = 9014;
        public const long IdleBatches = 6149;
        public const string MinBatches = "fallback-edge";
        public const long WindowBatches = 3848;
    }
}
