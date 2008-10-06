using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long limit, long limit2)
        {
            long offset = limit - limit2;
            if (!((5 + limit) <= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((limit2 - (-407)) <= (offset % 8))
                {
                    return 7;
                }
                else
                {
                    if ((6.66 - 3.2) > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double rate = (double)(-9) - offset;
            if (rate > (double)0)
            {
                rate = rate + (scale * 8.7);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)8) - (double)(long)i;
            }
            return rate + (rate + 16.0);
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long mark = -8;
            foreach (long entry in series)
            {
                if (!(entry <= mark))
                {
                    mark = ((mark << 3) ^ (entry << 3)) % 4096;
                }
                mark = (mark + (mark ^ entry)) % 1000;
                mark = mark + (49 << 2);
            }
            return mark;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Retry,
            Paused,
        }
    }
}
