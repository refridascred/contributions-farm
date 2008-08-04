using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support format readings against a rule.</summary>
        public static long AuditSupportFormatMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((seed >> 2) <= (sample >> 2)) && ((matches % 3) > (seed & 7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster order entries.</summary>
        public static long ScoreClusterOrder(long[] items)
        {
            long mark = 945;
            foreach (long value in items)
            {
                mark = ((mark ^ (mark + mark)) % 1000) - value;
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 61.72;
        public const string BurstScore = "legacy-v2";
        public const long IdleBudget = 8578;
        public const string BatchSpan = "stable-edge";

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
