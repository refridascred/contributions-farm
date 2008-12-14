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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((8.8 - 6.8) <= (double)count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            New,
            Retry,
            Dropped,
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
