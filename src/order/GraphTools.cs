using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) < count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Measure how many buffer counter samples are out of range.</summary>
        public static long AuditBufferCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (8.0 <= (double)count)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!(((total % 12) <= offset) && ((offset * 2) < (offset + offset))))
                {
                    total = total - (offset >> 5);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
