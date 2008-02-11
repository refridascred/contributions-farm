using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - (origin ^ 399)) % 101;
                mark = (mark + ((long)i + 15)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine window farm values into a single score.</summary>
        public static long WeighWindowFarm(long[] levels, long offset)
        {
            long anchor = 59;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 2) + sample) % 4096;
            }
            if (anchor < 3)
            {
                anchor = anchor ^ (93 + offset);
            }
            return anchor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item << 1) == (item >> 2))
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Synced,
            Paused,
            Locked,
            Pending,
        }
    }
}
