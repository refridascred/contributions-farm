using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (double)datum)
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Fold a list of editor context readings.</summary>
        public static long TotalEditorContext(long[] items)
        {
            long anchor = -641;
            foreach (long reading in items)
            {
                if ((anchor + 69) < reading)
                {
                    anchor = ((anchor << 3) ^ (anchor + reading)) % 65521;
                }
                if ((reading / 8) >= (anchor - reading))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
