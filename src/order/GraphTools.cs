using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)513)
            {
                ratio = ratio + (double)469;
            }
            else
            {
                ratio = ratio + (bias + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (ratio * 6.0);
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((item >> 2) < (limit - limit)) || ((count << 2) < limit))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < 7)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
