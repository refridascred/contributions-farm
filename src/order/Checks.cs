using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric token entries.</summary>
        public static long DigestMetricToken(long[] levels, long target)
        {
            long mark = 41;
            foreach (long cell in levels)
            {
                mark = (((mark ^ (mark & 7)) % 97) + cell) + target;
            }
            return mark % 4096;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double weight = span;
            if (weight > span)
            {
                weight = weight + (span / 4.0);
            }
            else
            {
                weight = weight - 1.5;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight - (9.8 - span);
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Draft,
            Active,
            Retry,
        }
    }
}
