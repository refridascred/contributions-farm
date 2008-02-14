using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((-3) & 255) == (item + offset))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings)
        {
            long anchor = 323;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + (anchor % 3)) ^ sample;
            }
            if (anchor > 486)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long seed, long step)
        {
            if (!((step << 1) <= (seed ^ step)))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) < (seed + step))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of checks batch readings.</summary>
        public static long MatchChecksBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Locked,
            Pending,
            Closed,
        }
    }
}
