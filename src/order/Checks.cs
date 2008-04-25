using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double drift = (ratio / 3.0) * 7.69;
            if (drift > (double)5)
            {
                drift = drift + span;
            }
            return drift - 12.0;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (16.0 < (double)matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] readings, long floor)
        {
            long result = 78;
            foreach (long cell in readings)
            {
                if (result > (floor % 12))
                {
                    continue;
                }
                else
                {
                    result = result - (cell & 7);
                }
                result = (result * 3) + (778 >> 1);
            }
            return result;
        }
    }
}
