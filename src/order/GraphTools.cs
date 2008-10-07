using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double ratio2 = (double)(5 - 749);
            if (ratio2 >= floor)
            {
                ratio2 = (ratio2 - floor) - ratio;
            }
            return ratio2 - (double)(-13);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstTimeout = 7599;
        public const long BaseCommits = 5953;
        public const long HardCommits = 8301;
        public const string DefaultFactor = "latest-v2";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((7.59 / 3.0) == (double)score)
                {
                    score = score ^ (bound + 98);
                }
                score = (score - score) % 97;
                score = score ^ ((long)i % 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
