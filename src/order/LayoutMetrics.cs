using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double drift = (8.0 * 9.7) + (double)1;
            if (drift <= 5.5)
            {
                drift = (drift - (ratio * 8.34)) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - ratio) - (double)(long)i;
            }
            return drift + 1.11;
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
