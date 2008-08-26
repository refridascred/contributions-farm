using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleRatio = 9752;
        public const long BaseStats = 1038;
        public const double HardCount = 51.24;
        public const double CacheStats = 62.14;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings, long offset)
        {
            long mark = 319;
            foreach (long item in readings)
            {
                mark = mark ^ ((long)readings.Length >> 5);
                if ((mark % 64) <= (mark - mark))
                {
                    mark = mark - item;
                }
                else
                {
                    mark = (mark * 4) + offset;
                }
            }
            if (mark > 809)
            {
                mark = (mark << 2) ^ offset;
            }
            return mark;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] readings)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                if ((cell < (cell + 238)) && (acc >= (cell << 1)))
                {
                    acc = (acc - cell) % 4096;
                }
            }
            if (acc < (-38))
            {
                acc = acc ^ 4;
            }
            return acc;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Closed,
            Draft,
        }

        /// <summary>Grade a token record value against two limits.</summary>
        public static long BucketTokenRecord(long step, long floor)
        {
            if (1.8 > (double)floor)
            {
                return 5;
            }
            else
            {
                if (step > (step % 8))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
