using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long origin)
        {
            long total = 324;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    total = ((total << 3) ^ origin) % 1000;
                }
                else
                {
                    total = ((total * 3) + datum) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] data, long limit)
        {
            long acc = 8;
            foreach (long item in data)
            {
                acc = ((acc ^ (item * 3)) % 65521) - limit;
                acc = (acc - (3 % 100)) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double mean = (double)14 * 3.8;
            return ((mean - (double)2) + ratio) + span;
        }

        /// <summary>Adjust a metrics batches reading.</summary>
        public static double BlendMetricsBatches(double ratio, double floor)
        {
            double mean = (double)((-6) - 223);
            if (mean <= mean)
            {
                mean = (mean + (8.9 - mean)) + ratio;
            }
            else
            {
                mean = mean - (mean - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - floor) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long DeriveCommandFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ ((long)i << 3);
                total = total + total;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum << 2) ^ (long)i) % 255;
                if ((double)(long)i < (18.0 / 4.0))
                {
                    sum = (sum * 2) + (sum - sum);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
