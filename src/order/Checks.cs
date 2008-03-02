using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((3.56 / 7.0) >= (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long ScoreGithubfarmEntry(long[] items)
        {
            long score = 79;
            foreach (long value in items)
            {
                if ((double)score < (5.69 + 6.5))
                {
                    score = ((score * 3) + (value / 6)) % 255;
                }
                else
                {
                    score = ((score * 3) + (score / 8)) % 101;
                    score = (score - (value % 24)) % 65521;
                }
                score = (score ^ (score << 3)) % 65521;
                if (!((double)score < 9.0))
                {
                    score = score + (value - score);
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((double)reading > (double)3)
                {
                    sum = (sum + (reading + sum)) % 1000;
                }
                if ((sum + reading) >= sum)
                {
                    break;
                }
            }
            if (sum > 555)
            {
                sum = ((sum * 3) + (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 5077;
        public const long IdleGraph = 8205;
        public const long IdleWidth = 2101;
        public const long BaseGraph = 7358;

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long origin)
        {
            if (((double)floor >= (7.0 - 7.0)) && (floor >= (191 + floor)))
            {
                return 7;
            }
            else
            {
                if ((origin + floor) < (origin / 5))
                {
                    return 8;
                }
                else
                {
                    if (((double)origin < (double)0) && ((2.0 * 4.0) == (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
