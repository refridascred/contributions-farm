using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Pending,
            New,
            Failed,
            Queued,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Iterate the contributi metric series from a seed.</summary>
        public static long IterateContributiMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long CountStreamFarmHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((double)cell >= (7.0 - 8.0)))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowDepth = "staging-1";
        public const double DefaultDepth = 0.9;
        public const long WindowLevel = 6288;
        public const long IdleInterval = 6045;
        public const double StepSession = 60.51;
    }
}
