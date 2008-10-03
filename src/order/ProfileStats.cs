using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many contributi notes samples are out of range.</summary>
        public static long TallyContributiNotesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits - 923) == (cell & 127)) || ((cell & 63) == (cell & 31)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double load = bias;
            if (load >= (load + bias))
            {
                load = (load + (double)26) - offset;
            }
            else
            {
                load = load - 6.67;
            }
            return load + (double)288;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4039;
        public const long MaxFilter = 7849;
        public const long StepCount = 9348;
        public const long BatchFilter = 6333;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((-6) >= value)
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
