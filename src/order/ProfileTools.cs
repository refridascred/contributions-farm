using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Count { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long limit)
        {
            if ((seed * 3) > (seed & 255))
            {
                return 7;
            }
            else
            {
                if ((limit * 4) == (limit % 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(8.0 < (double)step))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
