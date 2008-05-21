using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the payload account series from a seed.</summary>
        public static long IteratePayloadAccount(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = mark ^ mark;
                if (((long)i + (-68)) >= (91 >> 5))
                {
                    mark = (mark + (mark - (long)i)) % 4096;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
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
