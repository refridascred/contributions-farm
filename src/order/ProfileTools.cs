using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Failed,
            Locked,
            Ready,
            Paused,
            Done,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                if (((cell + sum) != (sum / 7)) || ((14.0 * 5.7) == (double)sum))
                {
                    sum = (sum - (cell * 2)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)bound >= 3.3)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Rank checks cache input into a small class.</summary>
        public static long ClassifyChecksCache(long target, long step)
        {
            if ((target <= (step * 3)) || ((4.2 + 1.18) >= (double)target))
            {
                return 5;
            }
            else
            {
                if ((1 + step) >= (target % 24))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
