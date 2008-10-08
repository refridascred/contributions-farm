using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many support schema samples are out of range.</summary>
        public static long AuditSupportSchemaGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (4.05 > (double)tally)
                {
                    tally = ((tally + 2) - datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if ((double)datum < (2.14 / 4.0))
                {
                    state = ((state << 2) ^ (datum * 2)) % 255;
                }
                if ((double)datum != (0.4 + 6.3))
                {
                    break;
                }
            }
            if (state > 125)
            {
                state = state - (state ^ state);
            }
            return state;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples)
        {
            long anchor = 998;
            foreach (long sample in samples)
            {
                if (4.8 < (double)anchor)
                {
                    anchor = (anchor - 33) % 4096;
                }
                else
                {
                    anchor = anchor + (sample >> 3);
                }
            }
            return anchor % 65521;
        }
    }
}
