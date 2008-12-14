using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long score = 820;
            foreach (long entry in series)
            {
                score = (((score * 5) + (330 % 97)) ^ entry) + target;
            }
            return score;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((reading % 24) != (3 - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm queue samples are out of range.</summary>
        public static long TallyFarmQueueHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry >> 1) <= entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double gain, double floor)
        {
            double bias = 1.6;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + (gain - bias)) - (double)(long)i) - floor;
            }
            return bias - (bias / 5.0);
        }
    }
}
