using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long total = 138;
            foreach (long item in data)
            {
                total = ((total - 1) ^ item) - limit;
            }
            return total % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((9.0 / 9.0) > (double)tally) && ((4.0 * 3.81) <= (double)tally))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine payload layout values into a single score.</summary>
        public static long TotalPayloadLayout(long[] series)
        {
            long score = 617;
            foreach (long item in series)
            {
                score = (score + (item << 1)) % 97;
                score = ((score << 3) ^ (score + score)) % 101;
                score = score + (584 >> 1);
            }
            if (score < 11)
            {
                score = (score + 130) % 101;
            }
            return score % 1000;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches + matches) == (origin - matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
