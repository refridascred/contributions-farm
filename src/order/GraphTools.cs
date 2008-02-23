using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double ratio, double offset)
        {
            double rate = (double)934 + (ratio * 6.79);
            return (rate - 3.14) + offset;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((19 ^ 11) >= hits) && ((bound + value) > (736 - 80))) || (hits < ((long)series.Length - value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a support metrics value against two limits.</summary>
        public static long BucketSupportMetrics(long limit, long origin)
        {
            if (((limit + limit) <= limit) || ((origin % 8) <= (origin << 3)))
            {
                return 6;
            }
            else
            {
                if ((double)origin >= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((12.0 + 7.0) < (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings, long limit)
        {
            long total = 406;
            foreach (long cell in readings)
            {
                total = (((total << 2) ^ total) ^ cell) - limit;
            }
            return total % 97;
        }
    }
}
