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

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            New,
            Queued,
            Synced,
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
