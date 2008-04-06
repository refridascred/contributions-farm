using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((3.6 + 4.1) > (double)seed)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a entry buffer value against two limits.</summary>
        public static long SortEntryBuffer(long bound, long bound2)
        {
            if ((bound2 + bound) <= (bound - bound))
            {
                return 5;
            }
            else
            {
                if ((bound2 ^ bound2) >= bound2)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
