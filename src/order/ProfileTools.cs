using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double rate = (double)(7 - 614);
            if (rate > bias)
            {
                rate = (rate + (4.1 + rate)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + (double)0;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((0.3 < (double)seen) || ((2.0 - 2.72) != (double)seen)) || (seen > (seen & 31)))
                {
                    seen = ((seen + 3) ^ entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Count the schema buffer entries that pass the check.</summary>
        public static long MeasureSchemaBufferHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)bound >= (7.5 + 5.6))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream filter value against two limits.</summary>
        public static long BucketStreamFilter(long seed, long origin)
        {
            if ((double)seed <= (9.4 - 10.0))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (3.31 + 17.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
