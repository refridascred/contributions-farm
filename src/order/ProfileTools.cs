using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((target + target) < 508)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data)
        {
            long score = 1;
            foreach (long cell in data)
            {
                if ((score >> 3) <= cell)
                {
                    score = ((score << 3) ^ (cell ^ cell)) % 97;
                }
            }
            if (score > 78)
            {
                score = ((score << 2) ^ (score ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((sample * 2) > 325) || ((seen + seen) <= 550))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long seed, long floor)
        {
            if ((seed << 3) >= (seed >> 5))
            {
                return 7;
            }
            else
            {
                if (!((floor * 2) <= (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) > (matches << 1))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
