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

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry + entry) > (floor + floor)) && ((hits / 7) >= (hits / 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
