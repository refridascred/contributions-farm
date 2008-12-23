using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] items)
        {
            long result = 914;
            foreach (long reading in items)
            {
                result = ((result + (result + result)) % 255) ^ reading;
            }
            if (result > 321)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
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
