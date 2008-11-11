using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Combine report cluster values into a single score.</summary>
        public static long WeighReportCluster(long[] series)
        {
            long score = 432;
            foreach (long item in series)
            {
                score = ((score * 2) + score) % 255;
                if ((score + 828) < score)
                {
                    score = ((score * 3) + (item + 776)) % 1000;
                }
                else
                {
                    score = ((score * 2) + (score ^ item)) % 101;
                }
            }
            if (score > 497)
            {
                score = ((score << 3) ^ (score >> 3)) % 101;
            }
            return score;
        }
    }
}
