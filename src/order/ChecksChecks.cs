using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally % 2) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit tools contributi readings against a rule.</summary>
        public static long MeasureToolsContributiGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches <= (6.57 - 14.0))
                {
                    matches = ((matches + 1) - entry) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
