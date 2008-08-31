using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 1135;
        public const long CacheChannel = 9246;
        public const string WindowChannel = "alpha-1";
        public const long CacheRatio = 2089;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((floor - floor) > (reading & 7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count contributi batch pairs that satisfy a relation.</summary>
        public static long PairContributiBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up order filter samples.</summary>
        public static long MatchOrderFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples, long floor)
        {
            long score = 72;
            foreach (long item in samples)
            {
                if (!((item >> 3) != ((long)samples.Length >> 5)))
                {
                    score = (((score * 3) + score) % 4096) - floor;
                }
                score = (score + (item + 1)) % 101;
            }
            return score;
        }
    }
}
