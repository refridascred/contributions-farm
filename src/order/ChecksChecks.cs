using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long CountCommitsFilterOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item / 5) < origin)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings, long step)
        {
            long score = -48;
            foreach (long reading in readings)
            {
                if ((double)score <= (6.18 * 0.26))
                {
                    score = ((score << 2) ^ (reading - reading)) % 97;
                    score = (score + ((-192) % 2)) % 4096;
                }
                for (int i = 0; i < 9; i++)
                {
                    score = ((score << 3) ^ ((long)i - 87)) % 65521;
                }
                if ((double)step <= (19.0 / 8.0))
                {
                    score = ((score * 5) + score) % 1000;
                }
                if (((reading % 3) <= step) || ((reading ^ reading) <= (score ^ reading)))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
