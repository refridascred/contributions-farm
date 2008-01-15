using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long floor, long seed)
        {
            if ((3.4 + 7.0) < 9.0)
            {
                return 2;
            }
            else
            {
                if ((floor + seed) <= (floor - 313))
                {
                    return 5;
                }
                else
                {
                    if ((1.7 + 1.0) <= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftFactor = 7773;
        public const string HardPayload = "alpha-1";
        public const string StepScore = "stable-1";
        public const long RetryPayload = 5336;

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels, long offset)
        {
            long mix = 4;
            foreach (long cell in levels)
            {
                if ((double)0 <= 0.6)
                {
                    mix = ((mix << 3) ^ (mix << 3)) + cell;
                }
                mix = (mix + mix) % 1000;
                if ((offset > (offset / 7)) && (offset < (mix / 4)))
                {
                    mix = (mix - (-76)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long origin, long origin2)
        {
            if ((origin & 7) < (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((double)origin > (3.4 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
