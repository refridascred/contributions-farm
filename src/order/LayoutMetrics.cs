using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stats metrics entries that pass the check.</summary>
        public static long MeasureStatsMetricsMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(entry >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 7) < (value + hits))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((result + result) < offset)
                {
                    result = (result + result) % 97;
                }
                if ((double)result < (17.0 / 2.0))
                {
                    break;
                }
                else
                {
                    result = (result - result) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
