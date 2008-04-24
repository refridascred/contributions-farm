using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((5.0 >= (double)count) && ((count + count) > (entry % 7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
