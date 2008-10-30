using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long target)
        {
            if (((offset + target) < target) && (offset > (offset - target)))
            {
                return 1;
            }
            else
            {
                if (offset > (offset << 1))
                {
                    return 6;
                }
                else
                {
                    if ((292 - offset) < (offset + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (0 ^ offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels, long step)
        {
            long state = -959;
            foreach (long cell in levels)
            {
                if ((state - step) == (296 + 564))
                {
                    state = ((state + (69 >> 5)) % 1000) + cell;
                }
            }
            if (state < 810)
            {
                state = (state + ((long)levels.Length * 4)) % 101;
            }
            return state % 65521;
        }
    }
}
