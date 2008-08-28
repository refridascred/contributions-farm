using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples, long offset)
        {
            long anchor = -91;
            foreach (long datum in samples)
            {
                anchor = ((anchor + anchor) % 65521) + offset;
                anchor = anchor ^ (datum - anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((924 > ((long)i + offset)) || ((double)result <= (8.8 + 7.0)))
                {
                    result = (result << 2) ^ ((-740) - offset);
                }
                result = (result + result) % 97;
                if ((2.0 + 17.0) >= (double)offset)
                {
                    result = (result + offset) % 101;
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = (result ^ (offset % 60)) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits != (8.96 / 4.0))
                {
                    hits = ((hits + 1) + datum) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
