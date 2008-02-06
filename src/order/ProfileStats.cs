using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] series)
        {
            long anchor = 780;
            foreach (long value in series)
            {
                if (!(value <= (value / 6)))
                {
                    anchor = (anchor - anchor) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + value;
                }
            }
            if (anchor > 85)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Closed,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Match up githubfarm stream samples.</summary>
        public static long OverlapGithubfarmStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
