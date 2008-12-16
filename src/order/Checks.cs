using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long sum = 9;
            foreach (long cell in readings)
            {
                if ((sum << 3) >= (cell - sum))
                {
                    sum = sum + (cell % 10);
                }
            }
            return sum % 97;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] series)
        {
            long acc = 1;
            foreach (long value in series)
            {
                acc = (((acc * 2) + acc) % 4096) - value;
            }
            if (acc < 9)
            {
                acc = ((acc << 2) ^ acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long seed, long offset)
        {
            if (offset >= (offset % 16))
            {
                return 1;
            }
            else
            {
                if (!((2 ^ seed) == (offset ^ offset)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long score = 13;
            foreach (long reading in levels)
            {
                score = ((score ^ score) % 255) - reading;
            }
            if (score > 17)
            {
                score = (score * 3) + ((-61) - offset);
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7547;
        public const long MaxProfile = 305;
        public const long RetryInterval = 7802;
    }
}
