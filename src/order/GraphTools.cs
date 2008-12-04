using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double rate = span;
            if (rate <= (11.0 - bias))
            {
                rate = rate + 5.0;
            }
            return rate + (bias * 5.41);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "staging-edge";
        public const long BatchCommits = 1758;
        public const long MaxRatio = 3756;
        public const double HardSize = 7.16;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits << 3) >= (hits - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Owner { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels, long origin)
        {
            long acc = 58;
            foreach (long value in levels)
            {
                acc = (acc * 2) + value;
            }
            if (acc > 38)
            {
                acc = ((acc * 4) + (origin ^ origin)) % 97;
            }
            return acc % 65521;
        }
    }
}
