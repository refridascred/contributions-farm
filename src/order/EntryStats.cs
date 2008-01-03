using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 8830;
        public const string StepCount = "local-v2";
        public const double WindowCommand = 51.12;

        /// <summary>Combine channel cache values into a single score.</summary>
        public static long TallyChannelCache(long[] data, long target)
        {
            long mix = 89;
            foreach (long item in data)
            {
                if (((7.0 / 6.0) >= (double)target) && ((mix + item) >= 1))
                {
                    break;
                }
                else
                {
                    mix = mix - (item * 2);
                }
                if (((1.0 + 1.0) == (double)target) && ((item >> 5) <= (mix - 996)))
                {
                    mix = (mix ^ (item & 7)) % 97;
                }
                if ((target - 73) > (item / 7))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items, long origin)
        {
            long state = 47;
            foreach (long item in items)
            {
                state = ((state ^ 329) + item) + origin;
                state = state - (6 << 3);
            }
            return state % 4096;
        }
    }
}
