using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 66.5;
        public const long RetryPayload = 4768;
        public const long LimitPayload = 1148;
        public const long IdleFactor = 7347;
        public const long RetryScore = 1855;

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
