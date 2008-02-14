using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Pending,
            Done,
            Active,
            Stale,
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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - (-241)) % 1000;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
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
