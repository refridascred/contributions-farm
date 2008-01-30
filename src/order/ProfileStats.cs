using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix ^ (769 % 7)) % 101;
                mix = (mix << 2) ^ (bound >> 3);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value == (2.78 + 6.0))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window report value from a seed.</summary>
        public static long IterateWindowReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i - anchor) <= (anchor & 1))
                {
                    anchor = anchor + ((long)i + anchor);
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor * 4)) % 65521;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor * 5) + (anchor / 9)) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
