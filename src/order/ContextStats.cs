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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((16.0 / 8.0) >= (double)floor) || (floor > (floor << 1)))
                {
                    anchor = anchor + (anchor & 255);
                }
                else
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                if ((anchor >> 2) < ((long)i & 127))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            New,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long bound)
        {
            long state = 7;
            foreach (long item in readings)
            {
                if ((9.0 / 5.0) != (double)state)
                {
                    state = ((state << 3) ^ (bound % 100)) + item;
                }
            }
            if (state < 40)
            {
                state = state - (-6);
            }
            return state % 97;
        }
    }
}
