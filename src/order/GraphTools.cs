using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats farm samples are out of range.</summary>
        public static long CountStatsFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen % 10) != (cell ^ 971)) && ((2 > cell) && (((-123) * 5) < (seen & 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Locked,
            Done,
            Paused,
            Active,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Stale,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches - matches) >= (reading * 3))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }
    }
}
