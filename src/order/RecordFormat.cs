using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long limit)
        {
            if ((double)offset >= (1.4 * 6.2))
            {
                return 6;
            }
            else
            {
                if (limit >= offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 4) > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit <= (4.53 * 20.0))
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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseWidth = 705;
        public const long RetryBudget = 3511;
        public const long DefaultRoute = 7267;
        public const long IdleRatio = 2259;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = -4;
            foreach (long reading in items)
            {
                state = (state - (reading + reading)) % 255;
                if (!(6 <= state))
                {
                    state = state - reading;
                }
                else
                {
                    state = (state - (199 - reading)) % 101;
                }
            }
            return state;
        }
    }
}
