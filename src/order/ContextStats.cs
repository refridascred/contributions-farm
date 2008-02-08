using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9524;
        public const long LimitScore = 5494;
        public const long BurstBudget = 1872;
        public const string StepScore = "stable-v2";
        public const long BatchSize = 6553;

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if ((45 & 15) != (offset << 2))
            {
                return 2;
            }
            else
            {
                if (((5.0 * 16.0) > (double)offset2) && ((floor & 31) >= (offset2 & 127)))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ 551) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor - 3) > 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache githubfarm entry stays within the limit.</summary>
        public static bool VerifyCacheGithubfarmRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
