using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 4831;
        public const string BatchSize = "staging";
        public const long MinOrder = 1495;
        public const string SoftLevel = "stable-edge";
        public const double WindowOrder = 29.57;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((long)levels.Length > (sample / 9))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double weight = bias2;
            if (weight < (double)377)
            {
                weight = weight - 10.0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (bias - weight)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((57 & 127) > value)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
