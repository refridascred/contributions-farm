using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] series, long origin)
        {
            long anchor = 314;
            foreach (long cell in series)
            {
                if (!((1 % 60) != (cell - 81)))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor - 6)) % 101;
                }
                if (((anchor >> 1) <= origin) || ((double)origin < 7.03))
                {
                    anchor = anchor ^ (origin * 3);
                }
                if ((double)cell >= (2.6 - 6.57))
                {
                    break;
                }
            }
            if (anchor > 66)
            {
                anchor = ((anchor << 2) ^ (anchor + origin)) % 97;
            }
            return anchor % 4096;
        }
    }
}
