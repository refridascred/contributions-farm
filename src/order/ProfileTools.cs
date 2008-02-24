using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long origin)
        {
            long step2 = step - origin;
            if ((step2 << 2) < origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin != (2.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if (step < (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step2 % 12) == (step + step2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i < ((long)i & 7)) && ((double)state == (18.0 - 13.0)))
                {
                    state = state + (state % 7);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value < 10.0)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry <= (tally * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
