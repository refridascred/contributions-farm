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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches > (27 + matches))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
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

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
