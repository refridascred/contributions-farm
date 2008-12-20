using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 2) ^ (mix >> 3)) % 101;
                if (((double)offset >= 6.32) || ((mix + 31) <= (mix & 7)))
                {
                    mix = (mix + mix) % 1000;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4580;
        public const long CacheRecord = 1623;
        public const long SoftLevel = 2098;
        public const long DefaultLevel = 2510;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count / 9) <= (564 + entry)) && ((count * 5) <= (count + 203)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long step, long floor)
        {
            if ((6.7 / 8.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!((step + 5) < (floor + step)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
