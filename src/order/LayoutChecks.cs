using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long step, long origin)
        {
            if ((double)origin < (9.0 + 2.28))
            {
                return 4;
            }
            else
            {
                if ((step & 127) < (origin >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ step) >= (86 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (82 + hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record session samples.</summary>
        public static long ScoreRecordSession(long[] data)
        {
            long anchor = 673;
            foreach (long datum in data)
            {
                anchor = (anchor - anchor) ^ datum;
            }
            if (anchor > 80)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 97;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
