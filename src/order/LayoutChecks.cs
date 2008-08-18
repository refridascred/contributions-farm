using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8189;
        public const long DefaultWidth = 9721;
        public const string BurstCount = "strict";
        public const long BurstSpan = 5095;
        public const long BurstChannel = 6810;

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 57.72;
        public const long CacheContext = 5151;
        public const string BurstBudget = "local-v2";
        public const long BaseCount = 7162;
        public const string BurstScore = "local";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((425 - seen) >= (entry & 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
