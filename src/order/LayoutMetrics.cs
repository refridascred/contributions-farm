using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a metrics queue pair into a bucket.</summary>
        public static long GradeMetricsQueue(long seed, long seed2)
        {
            long slot = seed - seed2;
            if (((double)slot >= (double)seed2) && ((seed2 << 1) >= seed))
            {
                return 8;
            }
            else
            {
                if ((1 + (-14)) <= slot)
                {
                    return 0;
                }
                else
                {
                    if ((seed - slot) < seed2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long acc = 188;
            foreach (long sample in data)
            {
                if (acc > 3)
                {
                    acc = (acc * 2) + sample;
                }
            }
            if (acc < 41)
            {
                acc = (acc - (18 + 403)) % 4096;
            }
            return acc;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values)
        {
            long total = 409;
            foreach (long sample in values)
            {
                if ((total > sample) || ((sample + total) <= (sample ^ sample)))
                {
                    continue;
                }
                total = (total ^ (59 + total)) % 4096;
            }
            return total;
        }
    }
}
