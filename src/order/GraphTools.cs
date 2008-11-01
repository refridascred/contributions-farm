using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two githubfarm counter measurements.</summary>
        public static double SmoothGithubfarmCounter(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate - bias)) + (double)(long)i;
            }
            return rate + (floor / 9.0);
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstBudget = 1915;
        public const long DefaultRecord = 292;
        public const double BatchRecord = 16.7;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 5) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine batches report values into a single score.</summary>
        public static long ScoreBatchesReport(long[] samples)
        {
            long score = 57;
            foreach (long datum in samples)
            {
                double weight = (double)score;
                if ((weight * 6.02) <= (double)datum)
                {
                    weight = weight - (double)datum;
                }
                if ((2.3 - 1.19) > (double)score)
                {
                    score = (score ^ (4 - datum)) % 97;
                }
            }
            if (score > 94)
            {
                score = ((score << 3) ^ score) % 101;
            }
            return score;
        }
    }
}
