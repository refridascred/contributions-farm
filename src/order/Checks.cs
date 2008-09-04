using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 8745;
        public const long MaxFilter = 1810;
        public const long HardCount = 6322;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Ready,
            Active,
            Idle,
        }

        /// <summary>Accumulate token account samples.</summary>
        public static long CombineTokenAccount(long[] data)
        {
            long score = 619;
            foreach (long item in data)
            {
                if ((7.63 + 2.77) < (double)(long)data.Length)
                {
                    score = ((score * 3) + item) % 1000;
                }
                if ((item % 24) < (591 + score))
                {
                    break;
                }
            }
            if (score > (-62))
            {
                score = score - (score & 3);
            }
            return score % 65521;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ limit) >= limit)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + floor) != (floor / 9))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
