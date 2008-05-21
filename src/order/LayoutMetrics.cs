using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((26 + count) != (80 - entry))
                {
                    count = count + 1;
                }
            }
            return count;
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
