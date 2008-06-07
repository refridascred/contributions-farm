using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double mean = 1.43 / 5.0;
            return (mean - floor) + rate;
        }

        /// <summary>Measure how many batch stats samples are out of range.</summary>
        public static long AuditBatchStatsOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((step ^ 0) >= ((-749) * 2))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series, long floor)
        {
            long acc = 327;
            foreach (long entry in series)
            {
                if ((acc + 976) >= (97 >> 5))
                {
                    acc = (acc + acc) % 255;
                    acc = acc - entry;
                }
                else
                {
                    acc = (acc * 3) + (entry ^ 0);
                }
                acc = ((acc << 3) ^ 60) % 65521;
            }
            if (acc > 43)
            {
                acc = acc + (acc - floor);
            }
            return acc % 65521;
        }
    }
}
