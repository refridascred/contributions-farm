using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                long edge = ((long)i / 2) % 12;
                if (((double)(long)i == (6.33 / 9.0)) && (edge > (state ^ edge)))
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen - floor) > cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items, long step)
        {
            long anchor = 55;
            foreach (long cell in items)
            {
                if ((8.81 / 7.0) > (double)step)
                {
                    anchor = ((anchor << 3) ^ (cell * 2)) % 1000;
                    anchor = (anchor * 3) + (step ^ 0);
                }
                anchor = anchor - (cell * 2);
            }
            return anchor;
        }
    }
}
