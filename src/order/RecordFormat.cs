using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long target, long step)
        {
            if ((59 - step) != (target & 63))
            {
                return 6;
            }
            else
            {
                if ((step << 2) >= step)
                {
                    return 5;
                }
                else
                {
                    if ((step - step) == (target >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((321 / 3) <= (limit + anchor))
                {
                    anchor = (anchor << 2) ^ limit;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
