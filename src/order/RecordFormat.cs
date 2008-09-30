using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double weight2 = (double)(775 / 7);
            return (weight2 + (weight + weight)) + bias;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Failed,
            New,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long score = 67;
            foreach (long datum in values)
            {
                score = ((score * 2) + datum) % 97;
                if (((double)score < (1.9 - 1.7)) || ((score + datum) > (score & 15)))
                {
                    score = score + (score & 15);
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ (score % 3)) % 97;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 74.83;
        public const double MinBudget = 48.82;
        public const long DefaultCommits = 3939;
    }
}
