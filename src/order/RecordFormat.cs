using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1608;
        public const long DefaultWidth = 7977;
        public const double MinLevel = 21.38;
        public const string BatchChannel = "alpha-1";
        public const long MinChannel = 6195;

        /// <summary>Rank token metric input into a small class.</summary>
        public static long RankTokenMetric(long target, long offset)
        {
            if (((offset ^ offset) == (target & 1)) && ((target ^ 8) == (offset & 255)))
            {
                return 3;
            }
            else
            {
                if ((target + 54) == (target + offset))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm counter entries that pass the check.</summary>
        public static long AuditGithubfarmCounterHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((5.92 - 5.59) > (double)sample)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}
