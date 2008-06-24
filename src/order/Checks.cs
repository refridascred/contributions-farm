using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long bound)
        {
            if ((double)bound <= (8.7 / 8.0))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) > step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((target - datum) != (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Stale,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state - step) % 97;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
