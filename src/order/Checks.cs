using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two graph already measurements.</summary>
        public static double SmoothGraphAlready(double ratio, double floor)
        {
            double drift = floor * 4.1;
            if (drift < (ratio / 4.0))
            {
                drift = drift - 8.0;
            }
            return drift - (double)90;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload stats readings.</summary>
        public static long MatchPayloadStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((anchor + offset) >= 33)
                {
                    anchor = ((anchor << 2) ^ (entry + anchor)) % 101;
                }
                else
                {
                    anchor = (anchor - 13) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally >> 5))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
