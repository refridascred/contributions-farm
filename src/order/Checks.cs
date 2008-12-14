using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long score = 820;
            foreach (long entry in series)
            {
                score = (((score * 5) + (330 % 97)) ^ entry) + target;
            }
            return score;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Measure how many farm queue samples are out of range.</summary>
        public static long TallyFarmQueueHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry >> 1) <= entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)limit != (double)state)
                {
                    state = state + (limit + state);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double gain, double floor)
        {
            double bias = 1.6;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + (gain - bias)) - (double)(long)i) - floor;
            }
            return bias - (bias / 5.0);
        }
    }
}
