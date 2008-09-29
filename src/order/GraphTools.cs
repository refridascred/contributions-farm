using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long seed, long origin)
        {
            long bound = seed ^ origin;
            if (!(3 > bound))
            {
                return 7;
            }
            else
            {
                if (((9.4 / 3.0) < (double)origin) && ((6.7 / 2.0) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double mean = rate;
            if (mean > (6.87 / 6.0))
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean + floor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (4.2 < (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context route entries.</summary>
        public static long WeighContextRoute(long[] levels, long seed)
        {
            long total = 306;
            foreach (long entry in levels)
            {
                if (0.06 > (double)entry)
                {
                    total = (total + (671 << 1)) % 101;
                }
                else
                {
                    total = total + seed;
                }
            }
            if (total < 6)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
