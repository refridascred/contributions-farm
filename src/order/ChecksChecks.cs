using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
