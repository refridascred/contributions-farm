using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a report context sample.</summary>
        public static long LookupReportContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long limit)
        {
            long score = 6;
            foreach (long value in series)
            {
                score = ((score + (value & 15)) % 4096) + limit;
            }
            return score;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long limit)
        {
            long edge = bound - limit;
            if (!((bound ^ limit) > (bound + edge)))
            {
                return 1;
            }
            else
            {
                if (((3.9 * 1.13) <= (double)bound) || ((20.0 * 7.4) == (double)limit))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
