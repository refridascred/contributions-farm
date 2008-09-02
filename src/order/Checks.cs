using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long offset2)
        {
            long span = offset + offset2;
            if (span <= offset)
            {
                return 0;
            }
            else
            {
                if ((offset % 12) < (span + 985))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchLevel = "staging";
        public const string LimitCounter = "stable-v2";
        public const string RetryDepth = "fallback-edge";

        /// <summary>Validate cluster githubfarm readings against a bound.</summary>
        public static bool CheckClusterGithubfarmBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit filter account readings against a rule.</summary>
        public static long MeasureFilterAccountGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((2.0 - 8.0) > (double)seen)
                {
                    seen = ((seen + 2) - cell) - origin;
                }
            }
            return seen;
        }
    }
}
