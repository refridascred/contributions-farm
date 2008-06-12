using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell > (cell >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "primary-1";
        public const string HardBudget = "staging-edge";
        public const long RetryFilter = 8194;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
