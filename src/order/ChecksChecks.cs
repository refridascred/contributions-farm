using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally <= 5.1)
                {
                    tally = ((tally + 2) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a notes metric sample.</summary>
        public static long LookupNotesMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
