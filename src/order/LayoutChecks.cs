using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1526;
        public const long SoftSession = 8391;
        public const double BatchCount = 16.95;

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double mean = gain;
            if (mean < gain)
            {
                mean = (mean + gain) - offset;
            }
            return mean + mean;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score - (score - (long)i)) % 1000;
                if ((double)(long)i == (14.0 * 3.55))
                {
                    score = (score << 3) ^ (long)i;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (offset >> 4)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin <= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if (target < (721 & 3))
                {
                    score = ((score << 3) ^ (score * 2)) % 255;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
