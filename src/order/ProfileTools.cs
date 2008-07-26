using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a buffer metric reading.</summary>
        public static double ProjectBufferMetric(double rate, double bias)
        {
            double mean = bias;
            if (mean < (double)24)
            {
                mean = mean - 2.9;
            }
            else
            {
                mean = mean + (rate * 7.47);
            }
            return mean + (mean - mean);
        }

        /// <summary>Project the next channel layout value.</summary>
        public static double SmoothChannelLayout(double rate, double span)
        {
            double load = (double)5 * 9.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - span) + (double)(long)i) - rate;
            }
            return load - (double)9;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples, long offset)
        {
            long total = -1;
            foreach (long item in samples)
            {
                if ((total ^ item) > total)
                {
                    total = (total - (offset + item)) % 4096;
                }
                if ((offset * 5) >= offset)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxSize = 2111;
        public const long HardFarm = 6259;
        public const double IdleFactor = 67.7;
    }
}
