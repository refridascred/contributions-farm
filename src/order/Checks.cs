using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading & 31))
                {
                    total = (total * 4) + (reading / 5);
                }
                if ((4 + 9) < total)
                {
                    total = total ^ (reading - 0);
                }
            }
            return total;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((matches & 31) >= (cell * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long target)
        {
            long next = seed - target;
            if ((target % 16) == (target ^ seed))
            {
                return 6;
            }
            else
            {
                if ((double)next <= (1.73 + 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((5.32 * 0.89) > (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target < 15.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
