using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 584;
        public const long SoftAccount = 1523;
        public const long LimitAccount = 8116;
        public const string HardSpan = "open";
        public const string WindowAccount = "primary";

        /// <summary>Count githubfarm tools pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long result = 931;
            foreach (long cell in series)
            {
                if ((31 & 7) < (cell * 4))
                {
                    result = (result << 2) ^ cell;
                }
            }
            return result;
        }
    }
}
