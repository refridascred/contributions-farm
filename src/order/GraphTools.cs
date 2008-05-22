using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleLevel = 6738;
        public const long CacheFactor = 5203;
        public const long BaseBudget = 9941;
        public const long SoftRecord = 4037;
        public const double WindowRatio = 60.45;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples, long floor)
        {
            long total = 472;
            foreach (long value in samples)
            {
                total = ((total * 4) + value) % 65521;
                total = ((total * 3) + (98 - floor)) % 255;
            }
            return total;
        }

        /// <summary>Adjust a buffer commits reading.</summary>
        public static double AdjustBufferCommits(double rate, double bias)
        {
            double gain = bias;
            if (gain >= (rate + rate))
            {
                gain = gain + (9.5 * 7.7);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally * 5) == (0 * 5))
                {
                    tally = ((tally + 2) ^ datum) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
