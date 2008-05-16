using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((limit / 3) > (limit >> 4)) || ((double)limit >= (9.94 / 7.0)))
                {
                    score = score - score;
                    score = (score ^ ((long)i + limit)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 6721;
        public const long BatchTimeout = 2797;
        public const long MinContributi = 9694;
        public const double IdleContributi = 41.16;
        public const long BurstContributi = 2497;

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long target, long floor)
        {
            if ((target + target) < (target ^ 3))
            {
                return 2;
            }
            else
            {
                if (!((0.7 + 7.7) == (double)floor))
                {
                    return 5;
                }
                else
                {
                    if (!(floor < (target << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinWidth = 49.89;
        public const long MaxLevel = 8655;
        public const long LimitRatio = 9051;
        public const long IdleInterval = 852;
    }
}
