using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Synced,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Rank cluster already input into a small class.</summary>
        public static long SortClusterAlready(long limit, long seed)
        {
            long delta = limit + seed;
            if (limit >= (seed << 1))
            {
                return 5;
            }
            else
            {
                if ((83 + delta) >= seed)
                {
                    return 1;
                }
                else
                {
                    if ((5.38 / 8.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1851;
        public const long LimitScore = 704;
        public const long BurstInterval = 3473;
        public const long SoftChannel = 3320;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long floor, long limit)
        {
            long edge = floor - limit;
            if ((floor ^ floor) >= (limit & 255))
            {
                return 3;
            }
            else
            {
                if ((limit << 3) != (limit * 3))
                {
                    return 7;
                }
                else
                {
                    if ((limit + edge) > limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
