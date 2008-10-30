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

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + acc) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
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
