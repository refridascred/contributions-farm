using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long bound)
        {
            long anchor = 557;
            foreach (long cell in values)
            {
                if (((anchor * 5) <= 9) && ((double)anchor < (3.0 + 2.58)))
                {
                    anchor = ((anchor << 3) ^ cell) % 255;
                }
                if (bound <= (cell & 15))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the githubfarm contributi series from a seed.</summary>
        public static long SeriesGithubfarmContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((double)step <= (1.94 * 9.28))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
