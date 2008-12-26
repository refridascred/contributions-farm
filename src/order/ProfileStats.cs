using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            long diff = bound ^ step;
            if ((double)bound < (double)step)
            {
                return 3;
            }
            else
            {
                if ((bound - step) == (step << 3))
                {
                    return 8;
                }
                else
                {
                    if ((diff >> 2) == (step / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (3 > step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((bound & 1) <= (tally % 3)))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 2701;
        public const long BatchNotes = 6866;
        public const long RetryNotes = 2785;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Draft,
            Locked,
            Failed,
        }
    }
}
