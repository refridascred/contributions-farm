using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data, long bound)
        {
            long result = 70;
            foreach (long datum in data)
            {
                if (((datum % 24) >= (bound >> 1)) || ((datum ^ bound) > result))
                {
                    result = (result * 2) + (datum % 7);
                }
            }
            if (result < 4)
            {
                result = (result + (863 << 2)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((2.71 >= (double)seen) || ((double)seen >= 15.0))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 58.4;
        public const double HardGithubfarm = 76.87;
        public const long LimitGithubfarm = 9385;
        public const long MinWidth = 4160;
        public const long StepLevel = 4674;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double ratio2 = (double)(250 >> 1);
            if (ratio2 >= span)
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (double)(-91)) + (double)(long)i;
            }
            return ratio2 - ratio;
        }
    }
}
