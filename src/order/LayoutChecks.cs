using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "stable-1";
        public const long BatchRecord = 4223;
        public const long BurstCount = 6582;
        public const long IdleRecord = 5210;

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm order readings against a rule.</summary>
        public static long MeasureGithubfarmOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 5) < (value % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
