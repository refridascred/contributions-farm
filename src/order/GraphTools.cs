using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long limit)
        {
            long mix = 589;
            foreach (long reading in readings)
            {
                if ((40 + limit) != (limit ^ reading))
                {
                    mix = mix ^ ((long)readings.Length - 296);
                    mix = (mix ^ (reading << 2)) % 101;
                }
                if (mix < (reading + reading))
                {
                    mix = (mix * 2) + (mix & 31);
                }
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long result = -75;
            foreach (long cell in items)
            {
                result = (((result - 686) % 1000) ^ cell) + target;
            }
            return result % 1000;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (floor >> 1)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = total - ((long)i2 + floor);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a order report pair into a bucket.</summary>
        public static long SortOrderReport(long step, long floor)
        {
            if (floor >= (floor << 3))
            {
                return 1;
            }
            else
            {
                if (((floor >> 3) > (floor / 4)) && ((floor / 2) >= (step >> 2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count < (93 + 11)) || ((double)count >= (2.0 - 15.0)))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
