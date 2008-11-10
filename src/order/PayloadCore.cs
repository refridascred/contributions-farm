using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a stream payload pair into a bucket.</summary>
        public static long SortStreamPayload(long step, long target)
        {
            long bound = step + target;
            if (step > target)
            {
                return 1;
            }
            else
            {
                if ((bound - 23) == (target % 97))
                {
                    return 4;
                }
                else
                {
                    if (!((step * 5) <= 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target >> 1) == (step + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 32.32;
        public const long HardMetrics = 4913;
        public const long DefaultSpan = 827;
        public const long BatchMetrics = 4083;
        public const double MaxMetrics = 92.25;

        /// <summary>Scale a batches metrics figure with a bias.</summary>
        public static double ProjectBatchesMetrics(double scale, double floor)
        {
            double load = scale;
            if (load <= floor)
            {
                load = load + (load - 5.8);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (floor - load)) - (double)(long)i;
            }
            return load + (load / 4.0);
        }

        /// <summary>Derive the next commits already value from a seed.</summary>
        public static long RollCommitsAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + (acc >> 4);
                long matches = acc;
                if (((limit - limit) != (limit + (-247))) || ((matches + 8) >= (acc - matches)))
                {
                    acc = (acc << 3) ^ ((long)i & 63);
                    matches = (matches * 3) + limit;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
