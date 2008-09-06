using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long bound)
        {
            long anchor = -112;
            foreach (long entry in readings)
            {
                if (!(anchor < ((long)readings.Length * 3)))
                {
                    anchor = (anchor + entry) % 101;
                }
                anchor = (anchor << 2) ^ (bound + entry);
            }
            return anchor % 97;
        }

        /// <summary>Count the graph metric entries that pass the check.</summary>
        public static long MeasureGraphMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count & 15) >= (count - count))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Match up layout support samples.</summary>
        public static long MatchLayoutSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the support graph series from a seed.</summary>
        public static long SeriesSupportGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum << 2) ^ ((long)i ^ 46);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum + 0) % 97) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
