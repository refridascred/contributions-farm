using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long step, long target)
        {
            long bound = step + target;
            if (((bound >> 1) <= step) && ((step - step) == (step + bound)))
            {
                return 0;
            }
            else
            {
                if (((7.4 - 5.13) >= (double)step) || ((12.0 * 13.0) == (double)target))
                {
                    return 1;
                }
                else
                {
                    if (!((step << 3) >= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound ^ bound) < (bound + 618))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                long count = (7 << 3) + (total & 127);
                if (count <= (floor - count))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
