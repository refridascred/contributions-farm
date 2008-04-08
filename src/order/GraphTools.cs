using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxRatio = 4304;
        public const string SoftWidth = "legacy-1";
        public const string SoftReport = "cached-1";
        public const string MinBudget = "local-edge";

        /// <summary>Project the next already entry value.</summary>
        public static double ProjectAlreadyEntry(double ratio, double bias)
        {
            double gain = (10.0 + 4.0) * 5.0;
            if (gain > (6.7 + 3.08))
            {
                gain = (gain - 7.74) - ratio;
            }
            return gain + bias;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of session stats readings.</summary>
        public static long TotalSessionStats(long[] samples)
        {
            long score = 558;
            foreach (long item in samples)
            {
                if ((item - score) == (item << 1))
                {
                    score = ((score * 5) + (item + (-3))) % 101;
                }
                if ((item << 1) > (3 * 2))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double drift = floor - (double)367;
            if (drift >= (drift - weight))
            {
                drift = drift + (5.1 + weight);
            }
            return drift + (drift / 2.0);
        }
    }
}
