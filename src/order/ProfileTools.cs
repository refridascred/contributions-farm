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

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Stale,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token order input into a small class.</summary>
        public static long ClassifyTokenOrder(long floor, long limit)
        {
            if (limit <= (limit + limit))
            {
                return 5;
            }
            else
            {
                if ((floor & 31) <= (-7))
                {
                    return 4;
                }
                else
                {
                    if ((11.0 + 1.5) <= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)floor <= (3.2 + 1.2)) && ((69 << 2) <= limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
