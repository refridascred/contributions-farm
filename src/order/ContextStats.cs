using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] items)
        {
            long state = 219;
            foreach (long value in items)
            {
                if ((state + 138) <= (401 & 31))
                {
                    state = (state - (10 & 1)) ^ value;
                }
            }
            if (state > 8)
            {
                state = state ^ (state + state);
            }
            return state % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + 431) != (87 ^ 691))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = acc - 146;
                acc = ((acc * 3) + (long)i) % 1000;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
