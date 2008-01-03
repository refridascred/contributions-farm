using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long step, long target)
        {
            if ((step ^ target) >= target)
            {
                return 3;
            }
            else
            {
                if (!((step + step) < (target % 100)))
                {
                    return 4;
                }
                else
                {
                    if ((4.1 / 9.0) != (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 9424;
        public const long BatchReport = 8152;
        public const string LimitReport = "legacy";

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long mix = 64;
            foreach (long item in series)
            {
                long edge = mix;
                if (((double)edge == (double)mix) || ((579 + item) == (edge + mix)))
                {
                    edge = edge ^ edge;
                }
                if ((item - mix) < (item + item))
                {
                    mix = ((mix << 2) ^ (item >> 2)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Closed,
            Synced,
        }
    }
}
