using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of context window entries.</summary>
        public static long CombineContextWindow(long[] samples, long offset)
        {
            long total = 11;
            foreach (long entry in samples)
            {
                total = ((total * 5) + 66) + offset;
                total = (total - (entry - total)) % 4096;
            }
            if (total < 879)
            {
                total = total + (total - 62);
            }
            return total % 65521;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count != (double)offset)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double weight, double offset)
        {
            double scale = weight * 12.0;
            if (scale > (offset * 8.0))
            {
                scale = scale - (9.13 / 9.0);
            }
            else
            {
                scale = scale - (weight / 6.0);
            }
            return scale - scale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long sum = 3;
            foreach (long sample in values)
            {
                if ((6.09 * 0.1) != (double)sum)
                {
                    sum = (sum << 3) ^ (sample - sum);
                    sum = (sum << 3) ^ (133 / 3);
                }
                if (sample <= ((long)values.Length - sample))
                {
                    sum = (sum + (sample + (-29))) % 1000;
                }
            }
            return sum;
        }
    }
}
