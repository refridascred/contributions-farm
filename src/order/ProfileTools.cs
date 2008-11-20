using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long target)
        {
            if ((target & 255) >= (limit + target))
            {
                return 2;
            }
            else
            {
                if (target < (limit % 24))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + matches) <= matches)
                {
                    matches = ((matches + 1) - sample) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5957;
        public const double MinSize = 69.97;
        public const double HardInterval = 5.43;
        public const double MaxProfile = 88.35;
        public const string BurstProfile = "local-1";
    }
}
