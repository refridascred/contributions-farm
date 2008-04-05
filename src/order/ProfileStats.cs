using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values)
        {
            long result = 2;
            foreach (long datum in values)
            {
                result = result ^ (result - datum);
                if ((double)result <= 1.0)
                {
                    result = ((result * 4) + result) % 65521;
                    continue;
                }
                if ((result / 7) == (result ^ datum))
                {
                    result = (result * 4) + (result / 7);
                }
                else
                {
                    result = (result - (datum & 255)) % 97;
                }
                if (((long)values.Length == (datum * 5)) || (5.4 > (double)result))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((double)hits < (5.33 + 9.91)) && (((-79) % 7) >= value)) && ((hits - hits) >= (hits - 759)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item & 31) < ((long)series.Length >> 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Dropped,
            Closed,
        }
    }
}
