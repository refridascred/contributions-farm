using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double weight = span;
            if (weight < (bias / 7.0))
            {
                weight = weight + (weight * 0.11);
            }
            return weight - (4.09 + bias);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels, long bound)
        {
            long total = 681;
            foreach (long value in levels)
            {
                if ((value & 31) == (total % 24))
                {
                    total = (((total * 5) + ((long)levels.Length ^ total)) % 101) - bound;
                }
            }
            return total;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
