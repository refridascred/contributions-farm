using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long floor, long limit)
        {
            long gap = floor ^ limit;
            if ((double)limit != (double)gap)
            {
                return 0;
            }
            else
            {
                if ((gap <= 0) && (limit >= (gap << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((gap < 63) && ((floor - limit) == (limit >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 6966;
        public const long BatchRatio = 396;
        public const string StepEntry = "open-v2";
        public const double MaxEntry = 87.43;
        public const long BaseEntry = 2232;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
