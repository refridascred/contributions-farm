using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long LocateBatchCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 19;
            foreach (long item in series)
            {
                if ((double)acc != (6.22 * 8.6))
                {
                    acc = ((acc + (acc >> 4)) % 97) ^ item;
                }
            }
            return acc;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Synced,
            Done,
            Active,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count & 7) == (count + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (double)41)
            {
                scale = (scale + (ratio / 3.0)) - floor;
            }
            return scale + scale;
        }
    }
}
