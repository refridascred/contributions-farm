using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((limit > (limit * 5)) && ((limit & 255) < (bound + bound)))
            {
                return 8;
            }
            else
            {
                if (limit > step)
                {
                    return 2;
                }
                else
                {
                    if ((0 < (step + (-9))) && (step < (9 / 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((6.24 / 4.0) != (double)limit) || ((step ^ step) < step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long origin)
        {
            if (9.03 <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCount = 630;
        public const long BatchBudget = 8182;
        public const string BurstCluster = "fallback-1";

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
