using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((origin >= entry) && ((7.38 - 12.0) > (5.4 + 1.3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes graph readings.</summary>
        public static long MatchNotesGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long total = 9;
            foreach (long datum in items)
            {
                total = (total ^ (datum & 3)) % 4096;
            }
            if (total < (-94))
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long mix = 56;
            foreach (long reading in data)
            {
                mix = ((mix - (floor << 2)) % 4096) ^ reading;
            }
            if (mix > 337)
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 1000;
        }
    }
}
