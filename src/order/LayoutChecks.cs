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

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long floor)
        {
            long diff = origin ^ floor;
            if ((double)floor <= (2.46 - 7.6))
            {
                return 8;
            }
            else
            {
                if (((diff - floor) >= (diff - diff)) || (floor >= (floor + diff)))
                {
                    return 2;
                }
                else
                {
                    if ((floor > (908 + floor)) || (7.0 <= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
