using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = result ^ (result << 3);
                result = ((result << 3) ^ 3) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double rate = floor;
            if (rate >= (double)5)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (floor * 13.0)) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long seed, long target)
        {
            if (((double)target < 0.4) && ((target + seed) <= (target + 975)))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) != (target << 1))
                {
                    return 4;
                }
                else
                {
                    if ((649 >= seed) || ((7.0 + 0.5) > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + count) >= (datum - datum))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 4047;
        public const long BatchGithubfarm = 8524;
        public const long WindowGithubfarm = 788;
        public const long DefaultGithubfarm = 1671;
        public const double LimitGithubfarm = 74.16;
    }
}
