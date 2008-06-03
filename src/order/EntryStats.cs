using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally > (tally ^ entry))
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

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double load = (bias * 6.6) - (18.0 + scale);
            if (load <= bias)
            {
                load = load - bias;
            }
            else
            {
                load = load + (double)89;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (6.02 * 9.19)) - (double)(long)i;
            }
            return load - (7.1 / 3.0);
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long target)
        {
            if (33 >= (target + target))
            {
                return 1;
            }
            else
            {
                if (55 <= (target ^ 69))
                {
                    return 5;
                }
                else
                {
                    if ((8.3 * 17.0) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
