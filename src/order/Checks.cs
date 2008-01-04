using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels, long step)
        {
            long result = -4;
            foreach (long datum in levels)
            {
                if ((result % 10) != (datum * 3))
                {
                    result = (result + (datum >> 3)) % 1000;
                }
                if (!((result + 63) > (step + step)))
                {
                    result = (result << 2) ^ datum;
                }
                else
                {
                    result = result ^ step;
                }
                if (2 < (datum * 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long floor)
        {
            long acc = 2;
            foreach (long sample in values)
            {
                if (3.7 < (double)sample)
                {
                    acc = ((acc << 2) ^ ((-9) - sample)) - floor;
                }
            }
            return acc;
        }
    }
}
