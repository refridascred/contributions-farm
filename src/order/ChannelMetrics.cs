using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((68 + matches) <= ((-15) << 2))
                {
                    matches = ((matches + 2) ^ item) + limit;
                }
            }
            return matches;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                if (5 > (anchor + offset))
                {
                    anchor = (anchor ^ ((long)i << 3)) % 4096;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long mark = 537;
            foreach (long cell in data)
            {
                if ((double)limit > 3.78)
                {
                    mark = ((mark * 5) + cell) % 101;
                }
            }
            if (mark > 68)
            {
                mark = mark + 394;
            }
            return mark % 97;
        }
    }
}
