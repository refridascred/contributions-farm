using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double ratio = 1.6;
            if (ratio <= (3.02 / 5.0))
            {
                ratio = (ratio + (double)44) - span;
            }
            return ratio - bias;
        }

        /// <summary>Count the counter account entries that pass the check.</summary>
        public static long TallyCounterAccountHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits << 2) == (208 + (-6)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data, long bound)
        {
            long anchor = 672;
            foreach (long reading in data)
            {
                anchor = (((anchor * 4) + reading) % 4096) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double load = scale;
            return (load + 6.2) + span;
        }

        /// <summary>Locate a batch account reading by value.</summary>
        public static long LookupBatchAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
