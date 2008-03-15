using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool GuardGraphContextLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor + anchor;
                anchor = anchor + ((long)i + offset);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double ratio = (double)617 - 5.16;
            if (ratio > (ratio + scale))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + (double)95;
        }
    }
}
