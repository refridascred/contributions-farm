using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a session githubfarm figure with a bias.</summary>
        public static double SmoothSessionGithubfarm(double scale, double floor)
        {
            double mean = (6.74 + 5.9) / 7.0;
            if (mean > mean)
            {
                mean = mean - (scale / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean - floor)) + (double)(long)i;
            }
            return mean + (double)14;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Idle,
            Active,
            New,
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
