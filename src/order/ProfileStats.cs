using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            New,
            Pending,
            Stale,
        }

        /// <summary>Classify a command commits pair into a bucket.</summary>
        public static long SortCommandCommits(long target, long floor)
        {
            long span = target + floor;
            if ((target < (217 + floor)) || ((target + 5) >= (floor - 803)))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) < span)
                {
                    return 4;
                }
                else
                {
                    if (!(floor > (target / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.33 - 0.71) < (double)span)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            New,
            Active,
        }
    }
}
