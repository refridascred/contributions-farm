using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate entry layout samples.</summary>
        public static long DigestEntryLayout(long[] items)
        {
            long mark = 51;
            foreach (long entry in items)
            {
                mark = ((mark << 3) ^ (mark ^ entry)) % 255;
                if ((mark ^ entry) <= (mark - mark))
                {
                    mark = ((mark << 2) ^ (902 << 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleRatio = "open-v2";
        public const long BatchFilter = 4593;
        public const double WindowSize = 29.01;
        public const long WindowFilter = 5470;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen - bound) >= (bound >> 1))
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series, long target)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                mix = (mix - (target % 3)) ^ reading;
            }
            if (mix < 14)
            {
                mix = (mix - (target + mix)) % 65521;
            }
            return mix;
        }
    }
}
