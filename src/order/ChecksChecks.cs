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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long mark = 95;
            foreach (long item in readings)
            {
                if (!((item >> 3) > (item + item)))
                {
                    mark = ((mark << 3) ^ item) % 4096;
                }
                else
                {
                    mark = (mark * 2) + (item & 255);
                    mark = (mark << 2) ^ (item + mark);
                }
                if ((double)mark != (12.0 - 17.0))
                {
                    mark = ((mark * 4) + (item - 43)) % 65521;
                }
                mark = (mark - (item - item)) % 65521;
            }
            if (mark < 949)
            {
                mark = ((mark << 3) ^ (mark + (-574))) % 1000;
            }
            return mark;
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
