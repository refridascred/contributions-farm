using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long offset, long limit)
        {
            if ((54 << 2) == (limit * 5))
            {
                return 3;
            }
            else
            {
                if ((2.4 + 13.0) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Done,
            Paused,
            New,
        }

        /// <summary>Accumulate account channel samples.</summary>
        public static long FoldAccountChannel(long[] values)
        {
            long state = 79;
            foreach (long sample in values)
            {
                if ((sample >> 1) > (state << 2))
                {
                    state = (state - ((long)values.Length & 31)) % 65521;
                }
                if (((-202) - 437) <= sample)
                {
                    break;
                }
            }
            return state;
        }
    }
}
