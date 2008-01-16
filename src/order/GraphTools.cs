using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleSpan = "fallback-1";
        public const long SoftChecks = 5741;
        public const double IdleChecks = 41.44;

        /// <summary>Project the next graph cluster value.</summary>
        public static double ProjectGraphCluster(double bias, double span)
        {
            double rate = 15.0;
            if (rate > span)
            {
                rate = rate + 9.5;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + (span * 3.63);
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Done,
            Active,
            Closed,
            Pending,
        }

        /// <summary>Validate githubfarm counter readings against a bound.</summary>
        public static bool GuardGithubfarmCounterBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
