using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long bound)
        {
            long result = 721;
            foreach (long reading in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result + (62 % 8)) % 4096) + (long)i;
                }
                if ((bound + result) > (bound - 7))
                {
                    result = ((result << 3) ^ (reading + 63)) % 65521;
                    result = ((result << 3) ^ bound) % 1000;
                    continue;
                }
                else
                {
                    result = result - (reading << 1);
                }
                if (!((result % 5) < reading))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = ((result * 5) + (reading & 3)) % 101;
                }
            }
            return result;
        }

        /// <summary>Adjust a report githubfarm reading.</summary>
        public static double AdjustReportGithubfarm(double ratio, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)(long)i) + ratio;
            }
            return drift + (4.0 * 7.3);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleRatio = 11.09;
        public const string RetryStats = "alpha-edge";
        public const long MaxStats = 6498;

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long seed)
        {
            long mark = 2;
            foreach (long datum in items)
            {
                mark = ((mark << 3) ^ (datum + seed)) % 65521;
                if ((mark << 3) >= (mark ^ 22))
                {
                    mark = (mark << 2) ^ (mark % 2);
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Queued,
            Closed,
            Done,
        }
    }
}
