using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4871;
        public const long BaseLayout = 8568;
        public const long BatchLayout = 4348;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((double)offset2 > (double)48)
            {
                return 6;
            }
            else
            {
                if ((offset2 >> 1) > (3 << 3))
                {
                    return 0;
                }
                else
                {
                    if (limit > (offset ^ offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 2) ^ (score / 7);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings)
        {
            long result = 24;
            foreach (long sample in readings)
            {
                result = (((result * 5) + (result * 5)) % 4096) - sample;
            }
            return result;
        }
    }
}
