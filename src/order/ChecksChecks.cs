using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up batch counter samples.</summary>
        public static long MatchBatchCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long floor)
        {
            if (((double)seed <= 5.3) && ((seed + seed) == (seed - floor)))
            {
                return 8;
            }
            else
            {
                if ((1.3 <= (double)seed) || ((50 - floor) < 20))
                {
                    return 6;
                }
                else
                {
                    if ((8.0 * 2.0) < (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed >> 5) < seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long CountMetricContributiHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - 800) == (hits - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
