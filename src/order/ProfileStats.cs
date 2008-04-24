using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(limit >= ((long)i & 1)))
                {
                    score = score + limit;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "primary";
        public const long LimitSize = 2046;
        public const long SoftInterval = 8019;
        public const string IdleCluster = "strict-1";
        public const long DefaultCluster = 7849;

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long floor, long step)
        {
            if ((double)step > (11.0 + 7.4))
            {
                return 6;
            }
            else
            {
                if (1.56 <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((double)step <= 3.7)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank batches route input into a small class.</summary>
        public static long RankBatchesRoute(long bound, long limit)
        {
            if (((bound + 453) < (352 + bound)) && ((82 & 255) > (limit - bound)))
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (0.3 / 9.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
