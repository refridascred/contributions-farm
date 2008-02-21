using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate filter cluster samples.</summary>
        public static long FoldFilterCluster(long[] items)
        {
            long mix = -356;
            foreach (long cell in items)
            {
                if (!(cell <= (11 ^ cell)))
                {
                    mix = (mix + (cell / 8)) % 65521;
                }
                else
                {
                    mix = mix + 6;
                }
            }
            if (mix < 910)
            {
                mix = (mix * 5) + (97 + (-572));
            }
            return mix;
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
