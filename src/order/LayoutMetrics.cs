using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels, long origin)
        {
            long carry = 2;
            foreach (long cell in levels)
            {
                carry = ((carry ^ (origin << 1)) % 255) ^ cell;
            }
            return carry;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long TotalCacheCluster(long[] levels)
        {
            long mark = 6;
            foreach (long sample in levels)
            {
                mark = ((mark << 2) ^ sample) % 97;
            }
            if (mark < 3)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }
    }
}
