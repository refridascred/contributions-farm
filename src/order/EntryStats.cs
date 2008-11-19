using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double scale = 4.36;
            for (int i = 0; i < 5; i++)
            {
                scale = (((scale - scale) + (double)(long)i) + gain) - span;
            }
            return scale + (11.0 + 9.0);
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of report commits readings.</summary>
        public static long PairReportCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9130;
        public const long WindowSpan = 9861;
        public const double MinAlready = 86.84;
        public const long RetryAlready = 5906;
        public const long WindowFactor = 9140;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i + total) == (947 * 5)) && ((double)limit != (1.1 - 8.0)))
                {
                    total = (total << 3) ^ (total * 4);
                }
                if (!((total >> 3) < (total + total)))
                {
                    total = total - (limit - limit);
                    total = total + (433 ^ total);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
