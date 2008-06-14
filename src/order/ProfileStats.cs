using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((double)76 <= (double)matches) && ((double)item >= (3.2 * 8.9))) && ((double)matches > 5.85))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many token counter samples are out of range.</summary>
        public static long TallyTokenCounterHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((74 >= (value / 5)) && (tally <= (value % 12))))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((value + matches) > value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile window sample.</summary>
        public static long SeekProfileWindowIndex(long[] series, long step)
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
    }
}
