using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = mix + (offset * 2);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long MeasureAlreadyBatchesOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (offset > hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
