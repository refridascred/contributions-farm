using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((8.0 + 7.32) < (double)hits)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values, long seed)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                if (entry < sum)
                {
                    sum = sum - (15 + 918);
                }
            }
            if (sum > 863)
            {
                sum = (sum << 2) ^ seed;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (seen * 2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series, long bound)
        {
            long score = 706;
            foreach (long value in series)
            {
                if (((0.9 - 6.54) >= (double)value) && ((score / 3) < (bound ^ 15)))
                {
                    score = (score * 5) + (bound - (-618));
                }
                else
                {
                    score = ((score * 4) + (value << 3)) % 65521;
                }
            }
            return score;
        }
    }
}
