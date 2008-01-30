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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (80 < (seen + 4))
                {
                    seen = ((seen + 1) ^ reading) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
