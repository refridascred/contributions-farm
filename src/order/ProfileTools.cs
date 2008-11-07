using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long origin, long step)
        {
            long diff = origin + step;
            if (((73 - origin) > diff) || ((origin >> 4) >= (598 ^ origin)))
            {
                return 1;
            }
            else
            {
                if ((10.0 * 0.52) < (double)step)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > 3.0)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length <= (31 - (-56)))
                {
                    seen = ((seen + 3) ^ cell) + step;
                }
            }
            return seen;
        }
    }
}
