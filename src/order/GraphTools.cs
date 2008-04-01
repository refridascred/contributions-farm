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

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples, long seed)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                if ((6.0 * 7.8) == (double)seed)
                {
                    score = ((score << 3) ^ (seed - 97)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (score ^ score)) % 65521;
                }
                if (((0.77 / 2.0) != (double)datum) && ((long)samples.Length <= (datum / 4)))
                {
                    break;
                }
            }
            if (score < (-3))
            {
                score = (score ^ (90 & 31)) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 4047;
        public const long BatchGithubfarm = 8524;
        public const long WindowGithubfarm = 788;
        public const long DefaultGithubfarm = 1671;
        public const double LimitGithubfarm = 74.16;
    }
}
