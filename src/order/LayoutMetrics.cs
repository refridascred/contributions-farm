using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit tools context readings against a rule.</summary>
        public static long TallyToolsContextOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ origin) >= (0 - origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
