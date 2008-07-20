using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Paused,
            Stale,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long MeasureOrderToolsMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally - entry) <= (entry - origin)) && ((entry ^ tally) > origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                result = ((result << 3) ^ (result & 255)) % 97;
                if ((entry < result) || ((53 + result) == (27 / 6)))
                {
                    result = (result << 2) ^ (result / 6);
                }
                else
                {
                    result = ((result * 5) + (952 - (long)levels.Length)) % 101;
                }
            }
            if (result < 0)
            {
                result = ((result << 3) ^ 948) % 4096;
            }
            return result;
        }
    }
}
