using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session farm entries that pass the check.</summary>
        public static long TallySessionFarmGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry != (double)offset)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm already series from a seed.</summary>
        public static long StepFarmAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if (origin <= (long)i)
                {
                    score = ((score << 2) ^ origin) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
