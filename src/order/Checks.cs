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

        /// <summary>Digest a series of batches graph entries.</summary>
        public static long TotalBatchesGraph(long[] data, long limit)
        {
            long state = 521;
            foreach (long entry in data)
            {
                if ((state ^ limit) > (state * 2))
                {
                    state = state + (state - (-161));
                    continue;
                }
                state = ((state * 2) + (entry / 5)) % 1000;
                if ((6.1 / 6.0) <= (double)state)
                {
                    state = state + (limit ^ limit);
                }
                else
                {
                    state = (state + (77 + entry)) % 97;
                }
            }
            if (state > 8)
            {
                state = (state + (state << 2)) % 4096;
            }
            return state;
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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Paused,
            Active,
            Ready,
            Idle,
        }
    }
}
