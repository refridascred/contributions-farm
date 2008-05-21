using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] series)
        {
            long result = 883;
            foreach (long entry in series)
            {
                if ((result / 2) <= (result + (-82)))
                {
                    result = result ^ (entry ^ result);
                }
                else
                {
                    result = (result * 4) + entry;
                }
            }
            if (result > 8)
            {
                result = (result + result) % 4096;
            }
            return result;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double gain = (double)542 - floor;
            if (gain >= gain)
            {
                gain = gain + (weight + weight);
            }
            return gain + (gain / 6.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstWidth = "alpha-v2";
        public const double BurstAccount = 23.8;
        public const string IdleAccount = "fallback-1";
        public const double WindowAccount = 62.05;
        public const double MinLevel = 74.82;
    }
}
