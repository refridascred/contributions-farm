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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (step < (step - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
