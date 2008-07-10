using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) <= matches)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine command contributi values into a single score.</summary>
        public static long CombineCommandContributi(long[] items, long bound)
        {
            long mark = 260;
            foreach (long sample in items)
            {
                mark = (mark + (sample / 4)) + bound;
            }
            if (mark < 826)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 1000;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Locked,
            Queued,
        }

        /// <summary>Match up checks token samples.</summary>
        public static long CompareChecksTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
