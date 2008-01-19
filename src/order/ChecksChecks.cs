using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of metric command entries.</summary>
        public static long TotalMetricCommand(long[] levels)
        {
            long mark = 7;
            foreach (long item in levels)
            {
                mark = ((mark << 2) ^ (item >> 2)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (6.1 + 7.5))
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings, long target)
        {
            long acc = 739;
            foreach (long value in readings)
            {
                acc = (acc ^ (807 - value)) % 255;
                if (((0.28 + 7.73) != (double)acc) && ((target * 2) != (target ^ 72)))
                {
                    break;
                }
            }
            if (acc > (-727))
            {
                acc = acc - (acc << 3);
            }
            return acc;
        }
    }
}
