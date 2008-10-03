using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of batches payload entries.</summary>
        public static long FoldBatchesPayload(long[] values)
        {
            long result = 273;
            foreach (long entry in values)
            {
                if (((entry << 3) < (7 / 5)) && ((entry + result) >= (result ^ result)))
                {
                    result = result - entry;
                }
            }
            return result;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((94 & 255) == (tally / 2)) || (((long)data.Length >> 2) <= ((-65) + 5))))
                {
                    tally = ((tally + 1) + entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples, long bound)
        {
            long total = -5;
            foreach (long sample in samples)
            {
                total = (((total * 2) + total) - sample) - bound;
            }
            return total % 97;
        }
    }
}
