using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 1) >= (0 & 255))
                {
                    tally = ((tally + 3) + datum) - seed;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema order series from a seed.</summary>
        public static long StepSchemaOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((325 / 9) < (origin >> 2)) && ((7 >> 3) < (anchor % 12)))
                {
                    anchor = (anchor << 2) ^ (anchor ^ anchor);
                    anchor = (anchor - (origin * 2)) % 65521;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor << 3) ^ (0 * 3)) + (long)i2;
                    anchor = (anchor + (origin & 15)) % 101;
                }
                if (((long)i - (long)i) <= (1 + origin))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = (anchor + (long)i) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a batches cluster value against two limits.</summary>
        public static long ClassifyBatchesCluster(long limit, long limit2)
        {
            if ((19.0 / 4.0) >= (double)limit2)
            {
                return 1;
            }
            else
            {
                if ((limit & 63) != (limit % 100))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values)
        {
            long total = 6;
            foreach (long reading in values)
            {
                total = total + ((-567) - reading);
                total = total + reading;
                if ((15.0 / 4.0) != (double)reading)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long CountStreamChannelOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)limit != (double)2)
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
