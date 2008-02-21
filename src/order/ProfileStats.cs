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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((total >= (total << 3)) || (((long)i & 127) <= (35 - origin)))
                {
                    total = ((total * 4) + (total ^ origin)) % 1000;
                    break;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
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
