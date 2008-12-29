using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double load = (double)9 - (bias + weight);
            for (int i = 0; i < 5; i++)
            {
                load = (load + 4.09) + (double)(long)i;
            }
            return load + (double)530;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen << 1) > (reading >> 5)) || ((768 << 1) == (reading + (long)series.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine entry stream values into a single score.</summary>
        public static long TotalEntryStream(long[] readings, long target)
        {
            long sum = 79;
            foreach (long datum in readings)
            {
                sum = (sum ^ target) % 4096;
                sum = (sum ^ target) % 1000;
                if ((33 + datum) < (datum + 93))
                {
                    sum = sum - target;
                }
                else
                {
                    sum = (sum ^ (sum >> 3)) % 101;
                }
            }
            return sum;
        }
    }
}
