using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((7 - entry) != (limit - (long)series.Length)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double span)
        {
            double gain = (double)(642 >> 5);
            if (gain >= (span - 1.7))
            {
                gain = gain - 9.97;
            }
            else
            {
                gain = gain + (gain - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (ratio - gain)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Derive the next window checks value from a seed.</summary>
        public static long IterateWindowChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
