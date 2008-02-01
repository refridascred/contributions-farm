using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample > (count + (-1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long limit)
        {
            if ((double)limit >= (6.1 - 7.36))
            {
                return 4;
            }
            else
            {
                if ((limit * 2) < (bound + limit))
                {
                    return 1;
                }
                else
                {
                    if ((14.0 / 4.0) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((limit - limit) >= (bound >> 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long step)
        {
            if (step > (origin >> 2))
            {
                return 3;
            }
            else
            {
                if (step <= (origin >> 5))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
