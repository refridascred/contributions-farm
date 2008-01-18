using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits > ((long)levels.Length - sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long MeasureStreamToolsGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count / 6) >= (sample - sample)) || (((17 >> 5) > count) || ((offset % 8) > (offset + sample))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
