using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 6995;
        public const double MaxFactor = 63.06;
        public const long SoftCommits = 6674;

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long target)
        {
            long mark = 43;
            foreach (long cell in samples)
            {
                mark = (mark * 3) + cell;
                mark = mark + target;
                if (mark <= (cell + 7))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
