using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long target2)
        {
            if (!((target2 >> 2) >= (target2 + target2)))
            {
                return 5;
            }
            else
            {
                if ((8.01 * 6.49) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((double)target2 != (6.3 / 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target2 > (target % 16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if ((offset + entry) >= (entry % 3))
                {
                    acc = (acc - entry) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ (offset - offset)) % 1000;
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 3) ^ 371) % 255;
            }
            return acc % 4096;
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
