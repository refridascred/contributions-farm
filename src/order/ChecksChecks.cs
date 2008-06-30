using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double load = offset;
            if (load < 0.94)
            {
                load = (load + (double)3) + gain;
            }
            else
            {
                load = load - 9.3;
            }
            return load - (double)74;
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] items, long seed)
        {
            long sum = 9;
            foreach (long value in items)
            {
                if ((sum < ((-27) ^ seed)) && (value > (sum - value)))
                {
                    sum = sum - (value - sum);
                }
            }
            if (sum < 358)
            {
                sum = (sum + (seed - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Combine buffer metric values into a single score.</summary>
        public static long DigestBufferMetric(long[] samples, long offset)
        {
            long total = 746;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total * 4) + (9 << 2)) % 65521) ^ (long)i;
                }
                total = (total + (offset ^ datum)) % 65521;
                if ((16.0 - 5.69) != (double)total)
                {
                    total = (total - total) % 101;
                }
            }
            if (total < (-1))
            {
                total = total ^ offset;
            }
            return total % 65521;
        }
    }
}
