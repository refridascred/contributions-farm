using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values, long step)
        {
            long result = 87;
            foreach (long sample in values)
            {
                if (result >= (sample >> 2))
                {
                    result = (result - sample) % 255;
                }
                if ((sample ^ sample) == (sample % 3))
                {
                    break;
                }
            }
            if (result > 20)
            {
                result = (result ^ (step / 3)) % 255;
            }
            return result;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                if (origin <= (state & 7))
                {
                    state = state - (origin << 1);
                    state = (state - (state / 4)) % 97;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + matches) <= (matches - matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
