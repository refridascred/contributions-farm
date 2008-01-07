using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] series)
        {
            long total = 28;
            foreach (long value in series)
            {
                if (!((double)value == (2.8 - 5.1)))
                {
                    total = ((total << 2) ^ (value % 5)) % 4096;
                }
            }
            if (total < 162)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
